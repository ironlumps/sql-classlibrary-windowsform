using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using GlobalAddressLibrary;

namespace GlobalAddress
{

    public partial class Form1 : Form
    {
        // Country Codes

        // R0 (57)
        // AD,AL,AS,AX,AZ,BB,BI,BM,BV,CD,CK,CM,DM,ER,FJ,FM,FO,GA,GH,GI,GL,GM,GN,GQ,HM,IQ,KG,KI,KM,LS,MC,MD,ME,MH,MK,MP,MT,NC,PF,PG,PN,PW,SB,SH,SJ,SL,SM,SO,SS,TG,TK,TM,TO,TV,UZ,VA,WS
        // R1
        // AT,AU,CH,CL,CZ,DE,DK,FI,FR,GB,HR,IE,IS,LI,LT,MX,NL,NO,NZ,PL,SE,SG,ZA

        // Example Tables

        // ALLR1_DIST20180221
        // ALLR1_DIST20180218Obj

        // ALLR1_DIST20180801Obj
        // ALLR1_DIST20180726Obj
        // ALLR1_DIST20180722Obj
        // ALLR1_DIST20180715Obj

        public Form1()
        {
            InitializeComponent();
        }

        GlobalAddressLibrary.AddressCheck check = new AddressCheck();

        private void btnRun_Click(object sender, EventArgs e)
        {
            #region Variables
            // Set of variables for the tables and country codes
            string table1 = txtTable1.Text;
            string table2 = txtTable2.Text;
            string table3 = txtTable3.Text;
            string table4 = txtTable4.Text;
            string table5 = txtTable5.Text;
            string table6 = txtTable6.Text;
            string countryCodes = txtCountryCodes.Text;
            // Set of variables for the check boxes 
            bool checkAC = chkAC.Checked;
            bool checkAE = chkAE.Checked;
            bool checkAV = chkAV.Checked;
            bool checkGE = chkGE.Checked;
            bool checkGS = chkGS.Checked;
            // Set of variables for the number variables
            double signif = (double)numSignif.Value;
            double error = (double)numErrorBounds.Value;
            // Variable to get the path of the file on the computer it is run on to store the results with the program
            string tempPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (tempPath.EndsWith("\\bin\\Debug") || tempPath.EndsWith("\\bin\\debug"))
            {
                int index = tempPath.IndexOf("\\bin");
                tempPath = tempPath.Remove(index);
            }
            string[] split = tempPath.Split('\\');
            string path = "";
            for (int i = 0; i < split.Length - 1; i++)
            {
                path += split[i] + "\\";
            }
            #endregion Variables

            if (check.CheckIfExists(path, table1, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS) != 0)
            {
                if (check.CheckIfExists(path, table2, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS) != 0)
                {
                    PrintResults(path, table1, table2, table3, table4, table5, table6, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS, signif, error);

                    Application.Exit();

                }
            }

        }
        public string ConvertDataTableToHTML(DataTable dt)
        {
            //string table1Country = check.GetCountry(table1, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
            //string table2Country = check.GetCountry(table2, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
            //string table1Total = check.GetTotal(table1, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
            //string table2Total = check.GetTotal(table2, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
            //string[] table1CountryArray = table1Country.Split(',');
            //string[] table2CountryArray = table2Country.Split(',');
            //string[] table1TotalArray = table1Total.Split(',');
            //string[] table2TotalArray = table2Total.Split(',');
            string html = "<table border = 1 style= width:30% >";
            //add header row
            html += "<tr align = center>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<td>" + dt.Columns[i].ColumnName + "</td>";
            html += "</tr>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr align = center>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    //// Checks for Changes with Error Bounds
                    //if ()
                    //{
                    //    // #FFF525 is highlighter yellow
                    //    html += "<td bgcolor = #FFF525>" + dt.Rows[i][j].ToString() + "</td>";
                    //}
                    //// Checks for Changes with Error Bounds
                    //else if ()
                    //{
                    //    // #FFF525 is highlighter yellow
                    //    html += "<td bgcolor = #FFF525>" + dt.Rows[i][j].ToString() + "</td>";
                    //}
                    //// Checks for Changes with Significance
                    //else if ()
                    //{
                    //    // ##32FF1E is neon green
                    //    html += "<td bgcolor = #32FF1E>" + dt.Rows[i][j].ToString() + "</td>";
                    //}
                    //else
                    //{

                    html += "<td >" + dt.Rows[i][j].ToString() + "</td>";
                    //}

                }
                html += "</tr>";
            }
            html += "</table>";
            return html;
        }
        public string PrintSignificance(DataTable dt, string path, double signif, string tableName)
        {
            DataTable sig = check.Significance(dt, path, signif, tableName);
            StreamWriter sign = new StreamWriter(path + tableName + "Significance.html");

            string signifcance = ConvertDataTableToHTML(sig);

            return signifcance;
        }
        public string PrintError(DataTable dt, string path, double error, string tableName)
        {
            DataTable err = check.ErrorBounds(dt, path, error, tableName);
            StreamWriter erro = new StreamWriter(path + tableName + "Error.html");

            string errorBounds = ConvertDataTableToHTML(err);

            return errorBounds;
        }

        public void PrintResults(string path, string table1, string table2, string table3, string table4, string table5, string table6, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS, double signif, double error)
        {
            string tables = table1 + "_" + table2 + "_" + table3 + "_" + table4 + "_" + table5 + "_" + table6;
            StreamWriter sw = new StreamWriter(path + tables + ".html");

            if (table1 != "" && table2 != "")
            {
                DataTable data = new DataTable();
                data = check.RunDataTableQuery(path, table1, table2);
                if (table3 != "")
                {
                    DataTable newData = new DataTable();
                    newData = check.RunMultipleQuery(data, path, table3, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
                    if (table4 != "")
                    {
                        DataTable moreData = new DataTable();
                        moreData = check.RunMultipleQuery(newData, path, table4, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
                        if (table5 != "")
                        {
                            DataTable fifthData = new DataTable();
                            fifthData = check.RunMultipleQuery(moreData, path, table5, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
                            if (table6 != "")
                            {
                                DataTable sixthdata = new DataTable();
                                sixthdata = check.RunMultipleQuery(fifthData, path, table6, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);

                                string fifthSet = ConvertDataTableToHTML(sixthdata);
                                string fifthSig = PrintSignificance(sixthdata, path, signif, table6);
                                string fifthErr = PrintError(sixthdata, path, error, table6);
                                sw.Write(fifthSet);
                                sw.Write(fifthSig);
                                sw.Write(fifthErr);
                            }
                            else
                            {
                                string fourthSet = ConvertDataTableToHTML(fifthData);
                                string fourthSig = PrintSignificance(fifthData, path, signif, table5);
                                string fourthErr = PrintError(fifthData, path, error, table5);
                                sw.Write(fourthSet);
                                sw.Write(fourthSig);
                                sw.Write(fourthErr);
                            }
                        }
                        else
                        {
                            string thirdSet = ConvertDataTableToHTML(moreData);
                            string thirdSig = PrintSignificance(moreData, path, signif, table4);
                            string thirdErr = PrintError(moreData, path, error, table4);
                            sw.Write(thirdSet);
                            sw.Write(thirdSig);
                            sw.Write(thirdErr);
                        }
                    }
                    else
                    {
                        string secondSet = ConvertDataTableToHTML(newData);
                        string secondSig = PrintSignificance(newData, path, signif, table3);
                        string secondErr = PrintError(newData, path, error, table3);
                        sw.Write(secondSet);
                        sw.Write(secondSig);
                        sw.Write(secondErr);
                    }
                }
                else
                {
                    string firstSet = ConvertDataTableToHTML(data);
                    string firstSig = PrintSignificance(data, path, signif, table2);
                    string firstErr = PrintError(data, path, error, table2);
                    sw.Write(firstSet);
                    sw.Write(firstSig);
                    sw.Write(firstErr); 
                }
            }
            else
            {
                sw.Write("No Entries");
            }

            sw.Close();
        }

    }
}