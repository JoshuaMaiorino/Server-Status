using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Server_Status.Model;

namespace Server_Status.Utility
{
    class FTPClient
    {
        public string username { get; set; }
        public string password { get; set; }
        public string ip { get; set; }
        public string port { get; set; }
        
        public T GetFile<T>( string saveGame ) where T : class, new()
        {
            var obj = new T();

            var gameFile = ( FarmingSimulator19GameFile )( object )obj;
            var fileName = gameFile.fileName;

            XmlDocument file = new XmlDocument();

            var ftpUri = string.Format( "ftp://{0}:{1}/profile/{2}/{3}"
                                        , this.ip
                                        , this.port
                                        , saveGame
                                        , fileName );
            string xmlString = "";

            try
            {
                FtpWebRequest request = ( FtpWebRequest ) WebRequest.Create( ftpUri );
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                request.Credentials = new NetworkCredential( this.username, this.password );

                FtpWebResponse response = ( FtpWebResponse ) request.GetResponse();

                XmlSerializer serializer = new XmlSerializer( typeof( T ) );

                Stream responseStream = response.GetResponseStream();

                var sr = new StreamReader( responseStream );
                
                obj = ( T ) serializer.Deserialize( sr );

                Console.WriteLine( $"{fileName} Download Complete, status {response.StatusDescription}" );

                sr.Close();
                response.Close();
                return obj;
            }
            catch (Exception ex )
            {
                Console.WriteLine( $"{fileName} failed to download: {ex.Message}" );
                Console.WriteLine( xmlString );
            }
            return null;
        }
    }
}
