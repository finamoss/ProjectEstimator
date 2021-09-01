using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ProjectCalc
{
    class NewProject
    {
        //Variables to determine Ink Cost from SQL Table, definted in From1.cs calculate btn event
        public string Size { get; set; }
        public string PaperType { get; set; }
        public string Ink { get; set; }
        public decimal InkCost { get; set; } 

        //Variables to determine Print Cost from SQL Table after Ink Cost is determined
        public int PageCount { get; set; }
        public int Copies { get; set; }
        public decimal PrintCost { set; get; }

        //Variables for Finishing

        /*From From1.cs*/
        public bool CornerStaple { get; set; }
        public bool SaddleStitch { get; set; }
        public bool Drill { get; set; }
        public bool Cutting { get; set; }

        public string FinishType { get; set; } /*Staples, Drill, Cutting*/
        public string Style { get; set; } /*Corner, Saddle, NULL*/

        /*Calculated Finsihing from SQL Table*/
        public decimal StapleCost { get; set; }
        public decimal CuttingCost { get; set; }
        public decimal DrillCost { get; set; }
        public decimal FinishingCost { get; set; }

        //Variables for Determining the # of sheets in a single file
        public bool Duplexing { get; set; } /*from form1.cs*/
        public int SheetNumFile { get; set; } /*calculated*/
        public int SheetNumProject { get; set; } /*calculated*/

        //TOTAL PROJECT COST
        public decimal TotalProjectCost { get; set; }
        public NewProject()
        {
            
        }

        public void getPricing()
        {
            //Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;

            string connectionString = "Data Source=DESKTOP-HUQMDPO;Initial Catalog=PaperDB;Integrated Security=True";
            string statement = "";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd;
            connection.Open();

            //Set number of sheets in the file
            if (Duplexing)
            {
                
                SheetNumFile = (int)Math.Ceiling((double)PageCount / 2);
            } else
            {
                SheetNumFile = PageCount;
            }

            SheetNumProject = SheetNumFile * Copies; //total sheet in project

            //Set Ink $ and Print $
            
            statement = $"SELECT Price from Paper WHERE Size = '{Size}' AND Ink = '{Ink}' AND PaperType = '{PaperType}'";
            cmd = new SqlCommand(statement, connection);
            InkCost = (decimal)cmd.ExecuteScalar();
            

            PrintCost = InkCost * Copies * PageCount;

            //Set Finishing Cost

            if (CornerStaple == true || SaddleStitch == true)
            {
                FinishType = "Staples";

                if (CornerStaple)
                {
                    Style = "Corner";
                }
                else
                {
                    Style = "Saddle";
                }
                statement = $"SELECT Price FROM finishing WHERE FinishType = '{FinishType}' AND Style = '{Style}'";
                cmd = new SqlCommand(statement, connection);
                StapleCost = (decimal)cmd.ExecuteScalar();
                StapleCost *= Copies;
            }
            
            if (Drill)
            {
                FinishType = "Drill";
                statement = $"SELECT Price FROM finishing WHERE FinishType = '{FinishType}'";
                cmd = new SqlCommand(statement, connection);
                DrillCost = (decimal)cmd.ExecuteScalar();
                DrillCost *= SheetNumProject;
            }

            if (Cutting)
            {
                /*Cutting is a flat cost - billed once per project*/
                FinishType = "Cutting";
                statement = $"SELECT Price FROM finishing WHERE FinishType = '{FinishType}'";
                cmd = new SqlCommand(statement, connection);
                CuttingCost = (decimal)cmd.ExecuteScalar();
            }
            //Set Finishing $
            FinishingCost = StapleCost + CuttingCost + DrillCost;
            
            connection.Close();


            //Set Total Project Cost $
            TotalProjectCost =  PrintCost + FinishingCost;

        }

        public override string ToString()
        {
            return $"Print Cost: {PageCount} x {Copies} x ${InkCost} ea. = {PrintCost.ToString("C")} \n" +
            $"Sheets: (File) {SheetNumFile} (Overall) {SheetNumProject}\n" +
            $"Staple Cost: {StapleCost.ToString("C")}\n" +
            $"Drill Cost: {DrillCost.ToString("C")}\n" +
            $"Cutting Cost: {CuttingCost.ToString("C")}\n" +
            $"TOTAL: {TotalProjectCost.ToString("C")}";
        }
    }
}
