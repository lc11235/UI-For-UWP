﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid.View;
using Windows.UI.Xaml;

namespace Telerik.UI.Xaml.Controls.Grid.Commands
{
    public class CellFlyoutActionContext
    {
        public CellFlyoutActionContext(DataGridCellInfo cellInfo, bool isOpen, CellFlyoutGesture gesture)
        {
            this.CellInfo = cellInfo;
            this.IsOpen = isOpen;
            this.Gesture = gesture;
        }

        /// <summary>
        /// Gets or sets the <see cref="DataGridCellInfo"/> instance over which a holding event has occured.
        /// </summary>
        public DataGridCellInfo CellInfo { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="FlyoutTemplate"/>.
        /// </summary>
        public DataTemplate FlyoutTemplate { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IsOpen"/> property which indicates whether the flyout should be opened or closed.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Gesture"/> property which indicates whether the flyout is triggered by a mouse or a touch input.
        /// </summary>
        public CellFlyoutGesture Gesture { get; set; }

    }
}
