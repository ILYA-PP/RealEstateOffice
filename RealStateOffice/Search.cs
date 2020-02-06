using System.Windows.Forms;

namespace RealStateOffice
{
    //оптимизация: повторяющиеся действия вынесены в отдельный класс
    class Search
    {
        public static void GetResult(DataGridView d, int[] c, string s)
        {
            string str = "";
            d.CurrentCell = null;
            foreach (DataGridViewRow row in d.Rows)
            {
                foreach (int i in c) str += row.Cells[i].Value.ToString() + " ";
                if (LevenschteinDistance.GetDistance(str, s) <= 7)
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        public static void Filter(DataGridView d, int c, string f)
        {
            d.CurrentCell = null;
            foreach (DataGridViewRow row in d.Rows)
                if (row.Cells[c].Value.ToString() != f || row.Cells[c].Value == null)
                    row.Visible = false;
                else row.Visible = true;
        }
        public static void Reset(DataGridView d)
        {
            foreach (DataGridViewRow r in d.Rows)
                r.Visible = true;
        }
    }
}
