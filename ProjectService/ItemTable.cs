using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
/*
namespace HandCodedFluentCUIT.Common
{
    public class ItemTable : HtmlTable
    {
        public ItemTable(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            SearchProperties[HtmlTable.PropertyNames.Id] = null;
            SearchProperties[HtmlTable.PropertyNames.Name] = null;
            FilterProperties[HtmlTable.PropertyNames.InnerText] = "GeveeActive\r\n Gevee: Product Development";
            FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "tabindex=\"0\" role=\"treegrid\" style=\"min-width: 961px;\"";
            FilterProperties[HtmlTable.PropertyNames.RowCount] = "4";
            FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "13";
            FilterProperties[HtmlTable.PropertyNames.Class] = null;
            FilterProperties[HtmlTable.PropertyNames.TagInstance] = "2";
            WindowTitles.Add("Microsoft Dynamics 365");
            #endregion
        }

        #region Properties
        public HtmlCell ItemCell
        {
            get
            {
                if (m_itemCell == null)
                {
                    m_itemCell = new HtmlCell(this);
                    #region Search Criteria
                    m_itemCell.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    m_itemCell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    m_itemCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    m_itemCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = null;
                    m_itemCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "role=\"gridcell\"";
                    m_itemCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                    m_itemCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "3";
                    m_itemCell.FilterProperties[HtmlCell.PropertyNames.Class] = null;
                    m_itemCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "30";
                    m_itemCell.WindowTitles.Add("Microsoft Dynamics 365");
                    #endregion
                }
                return m_itemCell;
            }
        }
        #endregion

        #region Fields
        private HtmlCell m_itemCell;
        #endregion
    }
}
*/