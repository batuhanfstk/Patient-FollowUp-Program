using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFollowUpProgram.Class
{
    [FirestoreData]
    internal class KullaniciData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]

        public string Password { get; set; }
       



    }
}
