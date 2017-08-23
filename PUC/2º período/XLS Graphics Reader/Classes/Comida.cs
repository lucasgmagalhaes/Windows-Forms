using Microsoft.Office.Interop.Excel;
using System;

namespace TI_FSI.Classes
{
    public class Comida : Tabela
    {
        private static int numlinComida = 0;
        public static int NumlinComida { get => numlinComida; }

        public Comida(Form1 frm) : base(frm)
        {
            this.form = frm;
            this.form.Send = this.form.charComida;
        }

        public override void GetInformations()
        {
            for (int aux = 2; aux <= ExcelFile.Xlrange.Rows.Count; aux++)
            {
                string xlsTipo = Convert.ToString((ExcelFile.Xlrange.Cells[aux, 1] as Range).Value2);

                if (xlsTipo != null && xlsTipo != "")
                {
                    numlinComida++;

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
                    QuantTotal[1] += Convert.ToInt32((ExcelFile.Xlrange.Cells[aux, 2] as Range).Value2);
                }
            }
        }
    }
}
