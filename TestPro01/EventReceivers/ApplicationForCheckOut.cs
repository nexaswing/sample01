using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace TestPro01.EventReceivers.ApplicationForCheckOut
{
    /// <summary>
    /// リスト項目イベント
    /// </summary>
    public class ApplicationForCheckOut : SPItemEventReceiver
    {
        /// <summary>
        /// 項目が追加されています.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            base.ItemAdding(properties);
        }

        /// <summary>
        /// 項目が更新されています.
        /// </summary>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            base.ItemUpdating(properties);
        }

        /// <summary>
        /// 項目が削除されています.
        /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            base.ItemDeleting(properties);
        }


    }
}