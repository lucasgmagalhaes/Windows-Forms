using System;
using System.Collections.Generic;
using FORM = System.Windows.Forms.DataVisualization.Charting;

namespace TI_FSI.Classes
{
   public abstract class Tabela : ITabela
    {
        protected Form1 form;
        protected List<DADOS> relatorio = new List<DADOS>();
        /// <summary>
        /// 0 - Roupa
        /// 1 - Comida
        /// 2 - Brinquedo
        /// </summary>
        protected static int[] QuantTotal = new int[3];

        public Tabela(Form1 frm)
        {
            this.form = frm;
        }

        public abstract void GetInformations();

        public virtual void LoadGraphics()
        {
            GetInformations();
            FORM.Series s = this.form.Send.Series.Add("Pie");
            s.ChartType = FORM.SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            int i = 0;
            foreach (DADOS each in relatorio)
            {
                s.Points.AddXY(each.info, each.valor);
                s.Label = "#VAL";
                s.Points[i].LegendText = each.info;
                i++;
            }
        }

        public void LimparLista()
        {
            this.relatorio.Clear();
        }
    }
}
