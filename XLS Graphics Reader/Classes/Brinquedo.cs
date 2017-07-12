using System;
using Microsoft.Office.Interop.Excel;

namespace TI_FSI.Classes
{
    public class Brinquedo : Tabela
    {
        private static int numlinBrinq = 0;
        public static int NumlinBrinq { get => numlinBrinq; }
        public Brinquedo(Form1 frm) : base(frm)
        {
            this.form = frm;
            this.form.Send = this.form.charBrinquedos;
        }

        public override void GetInformations()
        {
            for (int aux = 2; aux <= ExcelFile.Xlrange.Rows.Count; aux++)
            {
                string xlsTipo = "";

                double datadouble = (ExcelFile.Xlrange.Cells[aux, 4] as Range).Value2;
                xlsTipo = DateTime.FromOADate(datadouble).ToShortDateString();

                if (xlsTipo != null)
                {
                    numlinBrinq++;

                    if (this.relatorio.Count > 0)
                    {
                        if (this.relatorio.Exists(x => x.info == xlsTipo))
                        {
                            int ind = this.relatorio.FindIndex(item => item.info == xlsTipo);
                            this.relatorio[ind].valor++;
                        }
                        else this.relatorio.Add(new DADOS(xlsTipo, 1));
                    }
                    else this.relatorio.Add(new DADOS(xlsTipo, 1));
                    QuantTotal[2] += Convert.ToInt32((ExcelFile.Xlrange.Cells[aux, 2] as Range).Value2);
                }
            }
        }
    }
}
