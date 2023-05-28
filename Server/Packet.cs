using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public enum DataIdentifier
    {
        LogIn,
        SignUp,
        NULL
    }
    internal class Packet
    {
        private DataIdentifier dataIdentifier;
        private string username; //TAIKHOAN
        private string password; //MATKHAU

        public Packet()
        {
            this.dataIdentifier = DataIdentifier.NULL;
            this.username = null;
            this.password = null;
        }
        public DataIdentifier ChatDataIdentifier
        {
            get { return dataIdentifier; }
            set { dataIdentifier = value; }
        }
        public string taikhoan
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string matkhau
        {
            get { return this.password; }
            set { this.password= value; }
        }
        public Packet(byte[] dataStream)
        {
            // Read the data identifier from the beginning of the stream (4 bytes)
            this.dataIdentifier = (DataIdentifier)BitConverter.ToInt32(dataStream, 0);

            // Read the length of the username (4 bytes)
            int usernameLength = BitConverter.ToInt32(dataStream, 4);

            // Read the length of the password (4 bytes)
            int passwordLength = BitConverter.ToInt32(dataStream, 8);

            // Read the username field
            if (usernameLength > 0)
                this.username = Encoding.UTF8.GetString(dataStream, 12, usernameLength);
            else
                this.username = null;

            // Read the password field
            if (passwordLength > 0)
                this.password = Encoding.UTF8.GetString(dataStream, 12 + usernameLength, passwordLength);
            else
                this.password = null;
        }
        public byte[] GetDataStream()
        {
            List<byte> dataStream = new List<byte>();

            // Add the dataIdentifier
            dataStream.AddRange(BitConverter.GetBytes((int)this.dataIdentifier));

            // Add the username length
            if (this.username != null)
                dataStream.AddRange(BitConverter.GetBytes(this.username.Length));
            else
                dataStream.AddRange(BitConverter.GetBytes(0));

            // Add the password length
            if (this.password != null)
                dataStream.AddRange(BitConverter.GetBytes(this.password.Length));
            else
                dataStream.AddRange(BitConverter.GetBytes(0));

            // Add the username
            if (this.username != null)
                dataStream.AddRange(Encoding.UTF8.GetBytes(this.username));

            // Add the password
            if (this.password != null)
                dataStream.AddRange(Encoding.UTF8.GetBytes(this.password));

            return dataStream.ToArray();
        }
    }
}
