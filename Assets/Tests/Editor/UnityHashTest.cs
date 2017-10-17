using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityHash;
using System.Text;
using System.IO;

public class UnityHashTest
{
    string sampleString1 = "The quick brown fox jumps over the lazy dog";

    public static Stream GenerateStreamFromString(string s)
    {
        MemoryStream stream = new MemoryStream();
        StreamWriter writer = new StreamWriter(stream);
        writer.Write(s);
        writer.Flush();
        stream.Position = 0;
        return stream;
    }

    [SetUp]
    public void Setup ()
    {
    }

    [Test]
    public void ReturnCorrectMd5String ()
    {
        Assert.AreEqual ("9e107d9d372bb6826bd81d3542a419d6", HashUtil.MD5 (sampleString1));
    }

    [Test]
    public void ReturnCorrectMd5ByteArray ()
    {
        Assert.AreEqual ("9e107d9d372bb6826bd81d3542a419d6", HashUtil.MD5 (Encoding.UTF8.GetBytes(sampleString1)));
    }

    [Test]
    public void ReturnCorrectMd5Stream ()
    {
        using (var stream = GenerateStreamFromString (sampleString1)) {
            Assert.AreEqual ("9e107d9d372bb6826bd81d3542a419d6", HashUtil.MD5 (stream));
        }
    }

    [Test]
    public void ReturnCorrectRIPEMD160String ()
    {
        Assert.AreEqual ("37f332f68db77bd9d7edd4969571ad671cf9dd3b", HashUtil.RIPEMD160 (sampleString1));
    }

    [Test]
    public void ReturnCorrectRIPEMD160ByteArray ()
    {
        Assert.AreEqual ("37f332f68db77bd9d7edd4969571ad671cf9dd3b", HashUtil.RIPEMD160 (Encoding.UTF8.GetBytes(sampleString1)));
    }

    [Test]
    public void ReturnCorrectRIPEMD160Stream ()
    {
        using (var stream = GenerateStreamFromString (sampleString1)) {
            Assert.AreEqual ("37f332f68db77bd9d7edd4969571ad671cf9dd3b", HashUtil.RIPEMD160 (stream));
        }
    }

    [Test]
    public void ReturnCorrectSHA1String ()
    {
        Assert.AreEqual ("2fd4e1c67a2d28fced849ee1bb76e7391b93eb12", HashUtil.SHA1 (sampleString1));
    }

    [Test]
    public void ReturnCorrectSHA1ByteArray ()
    {
        Assert.AreEqual ("2fd4e1c67a2d28fced849ee1bb76e7391b93eb12", HashUtil.SHA1 (Encoding.UTF8.GetBytes(sampleString1)));
    }


    [Test]
    public void ReturnCorrectSHA1Stream ()
    {
        using (var stream = GenerateStreamFromString (sampleString1)) {
            Assert.AreEqual ("2fd4e1c67a2d28fced849ee1bb76e7391b93eb12", HashUtil.SHA1 (stream));
        }
    }
}
