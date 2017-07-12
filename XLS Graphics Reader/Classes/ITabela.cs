using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace TI_FSI.Classes
{
    interface ITabela
    {
        void GetInformations();
        void LoadGraphics();
    }
}
