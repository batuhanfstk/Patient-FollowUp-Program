using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace PatientFollowUpProgram.Class
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
{
  ""type"": ""service_account"",
  ""project_id"": ""patient-followup-5a2b9"",
  ""private_key_id"": ""c15a7281693cfafc31601de074be558d9933e627"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCrbyyh1EhuIQH4\neWCSq5+BLycwUCq9a0+5SvRUGleJm+Poyn8cz23Ir3V4tnNVLDbGUPs9V7KLygms\nr7zzXl7zdRYgeS5oQYXcinPXPkjrZxl0aeDmwk7KYOyH0tQjzip5T+Hh3dzxsdr0\nmLIiJrdFkmi6spuPLi41OYJXxJFWhHGCal9ojv1eqSnPgbz/tCuZwBCWWUpjHCG+\nAM0rZ3L4u7P6tpCiNdzr+QXoDdNsJ3Wt0Z2dgL6uOI6QlYKY7c/PvUnBl5q2JSMo\n2VIsDk9JS6hxi2uh/YggjbDKyVp1o5WCTvhSjFfHq42hO0buCzibE6lmUYpovjdM\nZuWKAZ8jAgMBAAECggEACv+QaPdyCCK0+ihrUi2Rh5urU3WpMErMrBILd8PS3uCx\n7/Lh0cra+7eJ/UsTPiEeiH2UiLxyF3bIRRxnLmPdCph16XJs0EJ34Iy/Xs0/p16P\nawEJ7TQFEwXB1vrnIj7tSage0TtHG/hxmCSdtQQv2NZKQsQHp9lqHH8Khi/1tQui\nLaQdNqn+ls6jnvi7wp4swo0S3IkyjeIhZEd+UdciZ/Trg4nxVBMtBT7AO/LYdmBA\n2Y4UJFWDMtLL8YDu2+EHhSV2JbndLW1brvq0eK6tMU6KIlNFePGFEjiV6Gx3Y6Di\n4/DNGZsocRa+5rzjTw7adu92hdtk0pBrrM+MSUI/eQKBgQDmkap2nX55g57Tnv6N\nJH+laFowNO4Wbh7//R8HHzAmnAhwrESoI0dt5+SgBz2D4Go/T8Zn/68YnyUuDckB\nXGP2sI5Sfqz6aGlrDKUT9rOjiUxSQoM1tc0vTmnWkvIonYUOxL+PGAIosCmqa7NL\nkEEtRDcWLJNlL5u08pdoBr3hGQKBgQC+V8iIoq8E8s2LlK5AH0fsl2Tgjni+rvUT\n988i2Y+KCQV+KAcexpCZy0FlExI5+nMB9IfdJxwsLD2tZKMEw5+XSsefXABWnMsG\niu8jm4tTzK2hNHTv298fY736+Y+Ku9IFPnog5n/ztjqPEGchZMgInLvpZE7VMIjv\n7wA5e66dmwKBgD7R8V/gCVWSRvPhnflWuHCYvfnkcfoqhse4b3vBQ51BZgtM5Gfr\nNMr9I412a4xC2K/nTGeJgmty8O5bUyjLw3CzKhPP79FKIW7JQzDtRoSIJANFm/pG\nTmFVPAD6iIAIavhbItYZ9HyhgrisH223IAr1Swz/mCk5j3L9pcLyE0oBAoGBALHa\nqolpoao5CfDTw6Is2HLs35in55EdP+khk43XxjTPyy8fTc/m8DSUZI2CLXS5XX9F\nMzJlGgD4ccU0FNMdy2B9wltYhwRnS5nYdi1KaPyrcs3/iwiY5TqaY2lAiWyzpUG7\nKDjXyFU8QClvxT3BwtuxQDCLxtGToVC4fPg5ZmbjAoGADcKspjKHGvSCRxvJtsl1\nwFEcRaiR8EyBDtIo3LWXnvruvxHz/nRklosh/xyebKLJv8zHzx/GPfoLHQqxZeO2\n8iz1qWs6ruud9DbPCT6XxUxNemhO5LwJbFYBsRXTEA02hjrwqlntjkaW/ymoFFQn\nSSIXk6KkgXXOqPCBxiXiXWo=\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-ujwt8@patient-followup-5a2b9.iam.gserviceaccount.com"",
  ""client_id"": ""117589097741975941876"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-ujwt8%40patient-followup-5a2b9.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}";

        static string filepath = "";
        public static FirestoreDb Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS" , filepath);
            Database = FirestoreDb.Create("patient-followup-5a2b9");




        }
    }
}
