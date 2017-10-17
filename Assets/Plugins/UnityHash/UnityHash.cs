using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace UnityHash
{
    public class HashUtil
    {
        protected static MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider ();
        protected static RIPEMD160 ripemd160 = new System.Security.Cryptography.RIPEMD160Managed ();
        protected static SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider ();

        protected static StringBuilder sb = new StringBuilder ();
        protected const string X2 = "x2";

        public static string MD5 (string input)
        {
            byte[] data = md5.ComputeHash (Encoding.UTF8.GetBytes (input));
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }
                
            return sb.ToString ();
        }

        public static string MD5 (byte[] input)
        {
            byte[] data = md5.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string MD5 (Stream input)
        {
            byte[] data = md5.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string RIPEMD160 (string input)
        {
            byte[] data = ripemd160.ComputeHash (Encoding.UTF8.GetBytes (input));
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string RIPEMD160 (byte[] input)
        {
            byte[] data = ripemd160.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string RIPEMD160 (Stream input)
        {
            byte[] data = ripemd160.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string SHA1 (string input)
        {
            byte[] data = sha1.ComputeHash (Encoding.UTF8.GetBytes (input));
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string SHA1 (byte[] input)
        {
            byte[] data = sha1.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

        public static string SHA1 (Stream input)
        {
            byte[] data = sha1.ComputeHash (input);
            sb.Length = 0;

            for (int i = 0; i < data.Length; i++) {
                sb.Append (data [i].ToString (X2));
            }

            return sb.ToString ();
        }

    }

}
