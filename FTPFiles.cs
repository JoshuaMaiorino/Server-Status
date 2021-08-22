using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace Server_Status
{
    class FTPFiles
    {
        public string username { get; set; }
        public string password { get; set; }
        public string ip { get; set; }
        public string port { get; set; }
        
        public XmlDocument GetFile( string path )
        {

            XmlDocument file = new XmlDocument();

            var ftpUri = string.Format( "ftp://{0}:{1}/profile/{2}"
                                        , this.ip
                                        , this.port
                                        , path );

            try
            {
                FtpWebRequest request = ( FtpWebRequest ) WebRequest.Create( ftpUri );
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                request.Credentials = new NetworkCredential( this.username, this.password );

                FtpWebResponse response = ( FtpWebResponse ) request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                XmlReader reader = XmlReader.Create( responseStream );


                file.Load( reader );

                Console.WriteLine( $"{path} Download Complete, status {response.StatusDescription}" );

                reader.Close();
                response.Close();
            }
            catch (Exception ex )
            {
                Console.WriteLine( $"{path} failed to download: {ex.Message}" );
            }
            return file;
        }
    }
}
