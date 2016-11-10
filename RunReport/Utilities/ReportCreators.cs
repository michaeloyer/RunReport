using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DataPull.Utilities
{
    public static class ReportCreators
    {
        public static TreeNode[] GetStandardReportCreatorNodes()
        {
            return ReportCreatorNodes(GetAllReportCreators());
        }

        private static IEnumerable<IReportCreator> GetAllReportCreators()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace == "DataPull.Reports" && !(t.IsAbstract || t.IsInterface))
                .Select(Activator.CreateInstance)
                .OfType<IReportCreator>();
        }

        private static TreeNode[] ReportCreatorNodes(IEnumerable<IReportCreator> creators)
        {
            //Parent node tags are null, child node tags are ReportCreator objects.
            return creators
                .OrderBy(creator => creator.Category)
                .ThenBy(creator => creator.ReportName)
                .GroupBy(creator => creator.Category)
                .CreateReportCreatorTreeNodes()
                .ToArray();
        }

        private static IEnumerable<TreeNode> CreateReportCreatorTreeNodes(this IEnumerable<IGrouping<string, IReportCreator>> groups)
        {
            foreach (var group in groups)
            {
                //Create Tree Node to be included in the IEnumerable
                var parentNode = new TreeNode(group.Key);
                foreach (var reportCreator in group)
                {
                    //Create TreeNodes to be put into the parentNode.
                    var childNode = new TreeNode(reportCreator.ReportName) { Tag = reportCreator };

                    parentNode.Nodes.Add(childNode);
                }

                yield return parentNode;
            }
        }
    }
}
