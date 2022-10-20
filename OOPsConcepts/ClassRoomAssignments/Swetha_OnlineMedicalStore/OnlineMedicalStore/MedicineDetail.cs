using System;
using System.Collections.Generic;
namespace OnlineMedicalStore
{
    /// <summary>
    /// used to get the medical store medicine details for purchacing
    /// 
    /// </summary>
    public class MedicineDetail
    {   

        /// <summary>
        /// used to get medicine id 
        /// </summary>
        private static int s_medicineId = 100;
        public string MedicineId { get; }
        /// <summary>
        /// used to get medicine name
        /// </summary>
        /// <value></value>

        public string MedicineName { get; set; }
        /// <summary>
        /// used to get medicine count for the user
        /// </summary>
        /// <value></value>

        public int MedicineCount { get; set; }
        /// <summary>
        /// used to get medicine price for purchacing
        /// </summary>
        /// <value></value>

        public double MedicinePrice { get; set; }
        /// <summary>
        /// used to get the expiry date for purchacing
        /// </summary>
        /// <value></value>

        public DateTime DateOfExpiry { get; set; }

        /// <summary>
        /// used to initialize the values using parameters
        /// </summary>
        /// <param name="medicineName">used to initialize the  medicine name through the parameter</param>
        /// <param name="medicineCount">used to intialize the medicine count through the parameter</param>
        /// <param name="medicinePrice">used to initialize the medicine price throgh the parameter for users purchacing</param>
        /// <param name="dateOfExpiry">used to inialize the date of expiry</param>

        public MedicineDetail(string medicineName,int medicineCount,double medicinePrice, DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineId = "MD"+s_medicineId;

            MedicineName = medicineName;
            MedicineCount = medicineCount;
            DateOfExpiry = dateOfExpiry;


        }






    }
}