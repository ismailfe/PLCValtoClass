using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDExcel;

namespace PLCValtoClass
{
    public partial class Form1 : Form
    {
        IDExcel.EXL EXL = new IDExcel.EXL();
        string UDT_Adi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void B_DosyaAc_Click(object sender, EventArgs e)
        {
            TB_Status.Text = EXL.READ_ExcelFile(DGV1, TB_DosyaYolu.Text, false, CB_Sayfa);
        }
        private void B_DosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Excel Dosyası|*.xls; *xlsx";
            fd.FilterIndex = 1;
            fd.ShowDialog();

            if (fd.CheckPathExists)
            { 
                TB_DosyaYolu.Text = fd.FileName.ToString();
                TB_Status.Text = EXL.READ_ExcelFile(DGV1, TB_DosyaYolu.Text, false, CB_Sayfa);
            }
        }
        private void B_ClassOlustur_Click(object sender, EventArgs e)
        {
            TB_Class_ValueSet.Clear();
            TB_Class_ValueCreate.Clear();
            tabControl1.SelectedTab = tabPage1;

            if (RB_READ.Checked)
            {
                TB_Class_ValueCreate.Text += "static int BufferByteIndexREAD    = XXXX \n ";
                TB_Class_ValueCreate.Text += "public int BufferByteREADLength   = BufferByteIndexREAD; \n ";
                TB_Class_ValueCreate.Text += "public byte[] BufferByteREAD      = new byte[BufferByteIndexREAD]; \n\n ";
                TB_Class_ValueCreate.Text += "public int Read_DBNo = XXXX \n\n ";
            }
            else
            {
                TB_Class_ValueCreate.Text += "static int BufferByteIndexWRITE        = XXXX \n ";
                TB_Class_ValueCreate.Text += "public int BufferByteWRITELength   = BufferByteIndexWRITE; \n ";
                TB_Class_ValueCreate.Text += "public byte[] BufferByteWRITE      = new byte[BufferByteIndexWRITE]; \n\n ";
                TB_Class_ValueCreate.Text += "public int Write_DBNo = XXXX \n\n ";
            }

                UDT_Adi = "";


            for (int i = 0; i < DGV1.RowCount - 1; i++) 
            {
                // LİSTEDEKİ DEĞİŞKENLERİ TESPİT ET (null Değilse)
                if (DGV1.Rows[i].Cells[2].Value != null)
                {
                    // LİSTEDEKİ DEĞİŞKENLERİ TESPİT ET (boş Değilse)
                    if (DGV1.Rows[i].Cells[2].Value.ToString() != "")
                    {
                        if (RB_READ.Checked)
                        {
                            CREATE_READ(i);
                        }
                        else
                        {
                            CREATE_WRITE(i);
                        }


                    }
                }

               
            }
        }

        #region WRITE
        public void CREATE_WRITE(int i)
        {
            // UDT ya da STRUCT VARSA BUNU DEĞİŞKEN ADINA AL
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("UDT") || DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Struct"))
            {
                // UDT ADINI AL
                UDT_Adi = DGV1.Rows[i].Cells[1].Value.ToString();
            }

            // LİSTEDEKİ INT DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString() == "Int")
            {
                WRITE_Val_INT(i, UDT_Adi);
            }

            // LİSTEDEKİ BOOL DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString() == "Bool")
            {
                WRITE_Val_BOOL(i, UDT_Adi);
            }


            // LİSTEDEKİ WSTRING DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Real"))
            {
                WRITE_Val_REAL(i, UDT_Adi);
            }

            // LİSTEDEKİ WSTRING DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("DInt"))
            {
                WRITE_Val_REAL(i, UDT_Adi);
            }
        }
        void WRITE_Val_BOOL(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            //   S7.SetBitAt(ref BufferByteWRITE, Pos, bitno, B_RST);
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += "S7.SetBitAt(ref " + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + pos[1] + "," + TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public bool " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "S7.SetBitAt(ref " + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + pos[1] + "," + TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public bool " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        void WRITE_Val_BYTE(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            //  S7.SetByteAt(BufferByteWRITE, Pos, ValByte);
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public byte " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text +  DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public byte " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        void WRITE_Val_INT(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

         //S7.SetIntAt(BufferByteWRITE, Pos, ValINT);
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] +","+ TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public short " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public short " + TB_ValueCreateOnEk.Text  + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        void WRITE_Val_DINT(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            // S7.SetDIntAt(BufferByteWRITE, Pos, ValDINT);
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public int " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public int " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        void WRITE_Val_REAL(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            // S7.SetRealAt(BufferByteWRITE, Pos, ValFloat);
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public float " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "S7.SetIntAt(" + TB_ValueSetOnEk.Text + "BufferByteWRITE," + pos[0] + "," + TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + ");  \n";
                TB_Class_ValueCreate.Text += "public float " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        #endregion

        #region READ
        public void CREATE_READ(int i)
        {
            // UDT ya da STRUCT VARSA BUNU DEĞİŞKEN ADINA AL
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("UDT") || DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Struct"))
            {
                // UDT ADINI AL
                UDT_Adi = DGV1.Rows[i].Cells[1].Value.ToString();
            }

            // LİSTEDEKİ INT DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString() == "Int")
            {
                READ_Val_INT(i, UDT_Adi);
            }

            // LİSTEDEKİ BOOL DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString() == "Bool")
            {
                READ_Val_BOOL(i, UDT_Adi);
            }
            

            // LİSTEDEKİ WSTRING DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("WString"))
            {
                READ_Val_WSTRING(i, UDT_Adi);
            }

            // LİSTEDEKİ STRING DEĞİŞKENLER
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("String"))
            {
                READ_Val_STRING(i, UDT_Adi);
            }

        }
        void READ_Val_BOOL(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + " S7.GetBitAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD, " + pos[0] + ", " + pos[1] + ");  \n";
                TB_Class_ValueCreate.Text += "public bool " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += "" + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + " S7.GetBitAt(BufferByteREAD, " + pos[0] + ", " + pos[1] + ");  \n";
                TB_Class_ValueCreate.Text += "public bool " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
        }
        void READ_Val_INT(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            if (UDT != "")
            {
                TB_Class_ValueSet.Text      += TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + " S7.GetIntAt( " + TB_ValueSetOnEk.Text  + "BufferByteREAD, " + pos[0] + ");  \n";
                TB_Class_ValueCreate.Text   += "public int " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + " S7.GetIntAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD, " + pos[0] + ");  \n";
                TB_Class_ValueCreate.Text +=  "public int " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; //" + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }

   
        }
        void READ_Val_WSTRING(int i, string UDT)
        {
            string[] pos    = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
            string[] Length = DGV1.Rows[i].Cells[2].Value.ToString().Split('[', ']');

            int PosAct      = int.Parse(pos[0]) + 4;         // Siemens Wstring de ilk 2 word string ile ilgili bilgi olarak gelir. Bu yüzden 4 Byte sonra başlanır.
            int LengthAct   = (int.Parse(Length[1]) * 2);   // Siemens Wstring de ilk 2 word string ile ilgili bilgi olarak gelir. Bu yüzden 4 Byte sonra başlanır.
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + "(S7.GetCharsAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD," + PosAct.ToString() + "," + LengthAct.ToString() + ")).Replace(\"\0\", string.Empty); " + " // DB Word Pos: " + pos[0] +"  \n";   
                TB_Class_ValueCreate.Text += "public string " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; " + " // DB Word Pos: " + pos[0] +" - " + DGV1.Rows[i].Cells[11].Value.ToString() + "\n"; 
            }
            else
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + "(S7.GetCharsAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD," + PosAct.ToString() + "," + LengthAct.ToString() + ")).Replace(\"\\0\", string.Empty);" + " // DB Word Pos: " + pos[0] + "  \n";
                TB_Class_ValueCreate.Text += "public string " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; " + " // DB Word Pos: " + pos[0] + " - " + DGV1.Rows[i].Cells[11].Value.ToString() + " \n";
            }

            //CLS.PLCVar.Barkod[i] = (S7.GetCharsAt(Buff_RDB0B, BarkodVal_ActPos, 44)).Replace("\u[0-9A-Fa-f]{4}", string.Empty);
        }
        void READ_Val_STRING(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
            string[] Length = DGV1.Rows[i].Cells[2].Value.ToString().Split('[', ']');

            int PosAct = int.Parse(pos[0]) + 0;         // Siemens Wstring de ilk 2 word string ile ilgili bilgi olarak gelir. Bu yüzden 4 Byte sonra başlanır.
            int LengthAct = (int.Parse(Length[1]) + 2);   // Siemens Wstring de ilk 2 word string ile ilgili bilgi olarak gelir. Bu yüzden 4 Byte sonra başlanır.
            if (UDT != "")
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + "(S7.GetCharsAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD," + PosAct.ToString() + "," + LengthAct.ToString() + ")).Replace(\"\\0\", string.Empty);" + " // DB Word Pos: " + pos[0] + "  \n";
                TB_Class_ValueCreate.Text += "public string " + TB_ValueCreateOnEk.Text + UDT + "_" + DGV1.Rows[i].Cells[1].Value.ToString() + "; " + " // DB Word Pos: " + pos[0] + " - " + DGV1.Rows[i].Cells[11].Value.ToString() + "\n";
            }
            else
            {
                TB_Class_ValueSet.Text += TB_ValueSetOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + " = " + "(S7.GetCharsAt( " + TB_ValueSetOnEk.Text + "BufferByteREAD," + PosAct.ToString() + "," + LengthAct.ToString() + ")).Replace(\"\\0\", string.Empty);" + " // DB Word Pos: " + pos[0] + "  \n";
                TB_Class_ValueCreate.Text += "public string " + TB_ValueCreateOnEk.Text + DGV1.Rows[i].Cells[1].Value.ToString() + "; " + " // DB Word Pos: " + pos[0] + " - " + DGV1.Rows[i].Cells[11].Value.ToString() + " \n";
            }

            //CLS.PLCVar.Barkod[i] = (S7.GetCharsAt(Buff_RDB0B, BarkodVal_ActPos, 44)).Replace("\u[0-9A-Fa-f]{4}", string.Empty);
        }

        #endregion

        private void B_TabloOlustur_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            CreateTable();
        }



        #region TABLO OLUŞTUR

        void CreateTable()
        {

            if (DGV_Result.Columns.Count > 0)
            {
                DGV_Result.Columns.Clear();
            }  

            DGV_Result.Columns.Add("ID", "ID");
            DGV_Result.Columns.Add("UpdateDate", "UpdateDate");
            DGV_Result.Columns.Add("PLC", "PLC");
            DGV_Result.Columns.Add("Name", "Name");
            DGV_Result.Columns.Add("Address", "Address");
            DGV_Result.Columns.Add("Type", "Type");
            DGV_Result.Columns.Add("Value", "Value");
            DGV_Result.Columns.Add("Comment", "Comment");
            UDT_Adi = "";

            for (int i = 0; i < DGV1.RowCount - 1; i++)
            {
                Var_Check(i);
            }
        }

        public void Var_Check(int i)
        {
            // UDT ya da STRUCT VARSA BUNU DEĞİŞKEN ADINA AL
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("UDT") || DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Struct"))
            {
                // UDT ADINI AL
                UDT_Adi = DGV1.Rows[i].Cells[1].Value.ToString();
            }

            if (DGV1.Rows[i].Cells[2].Value.ToString() != "" && !DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("UDT") && !DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Struct"))
            {
                DGVFilling(i, UDT_Adi);
            }
           
   
        }

        void DGVFilling(int i, string UDT)
        {
            string[] pos = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

            string Name = "";
            string Address = "";
            string ValType = "";

            if (UDT != "")
            {
                Name = UDT + "." + DGV1.Rows[i].Cells[1].Value.ToString();
            }
            else
            {
                Name = UDT + "." + DGV1.Rows[i].Cells[1].Value.ToString();
            }

            if (TB_DBNo.Text != "")
            {
                Address = TB_DBNo.Text + ".";
            }
            else
            {

            }
         

            ValType = DGV1.Rows[i].Cells[2].Value.ToString();

            if (DGV1.Rows[i].Cells[2].Value.ToString() == "Bool")
            {
                Address += "DBX" + DGV1.Rows[i].Cells[3].Value.ToString();
            }

            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Real"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

                Address += "DBD" + val1[0];
            }

            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("DInt"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');

                Address += "DBD" + val1[0];
            }
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Int"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
                Address += "DBW" + val1[0];
            }
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("String"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
                Address += "DBW" + val1[0];
            }
            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("WString"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
                Address += "DBW" + val1[0];
            }

            if (DGV1.Rows[i].Cells[2].Value.ToString().StartsWith("Byte"))
            {
                var val1 = DGV1.Rows[i].Cells[3].Value.ToString().Split('.');
                Address += "DBB" + val1[0];
            }
            if (Name.StartsWith("."))
            {
                Name = Name.Remove(0, 1);
            }
           
            DGV_Result.Rows.Add("", "","", Name, Address, ValType, "", "");
        }
        #endregion

        private void B_Export_DGVResult_Click(object sender, EventArgs e)
        {
            EXL.DGV_ExcelExport(DGV_Result);
        }
    }
}
