/*
 * MIT License
 *
 * Copyright (c) 2022-2023 Aptivi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Yunikodo
{
    internal static class UnicodeQueryHandler
    {
        static Stream cachedXmlStream = null;
        static Ucd cachedUcd = null;

        internal static void UnpackUnicodeDataToStream(UnicodeQueryType type)
        {
            // If we've cached, just bail
            if (cachedXmlStream == null)
            {
                // Select XML file based on type
                var unicodeData = Array.Empty<byte>();
                var xmlFile = "";
                switch (type)
                {
                    case UnicodeQueryType.Simple:
                        unicodeData = UnicodeData.ucd_nounihan_flat;
                        xmlFile = "ucd.nounihan.flat.xml";
                        break;
                    case UnicodeQueryType.Full:
                        unicodeData = UnicodeData.ucd_all_flat;
                        xmlFile = "ucd.all.flat.xml";
                        break;
                }

                // Unpack the ZIP to stream
                var archiveByte = new MemoryStream(unicodeData);
                var archive = new ZipArchive(archiveByte, ZipArchiveMode.Read);

                // Open the XML to stream
                cachedXmlStream = archive.GetEntry(xmlFile).Open();
            }
        }

        internal static Char Serialize(int charNum)
        {
            if (cachedUcd is null)
            {
                var serializer = new XmlSerializer(typeof(Ucd), "http://www.unicode.org/ns/2003/ucd/1.0");
                using var reader = XmlReader.Create(cachedXmlStream);
                cachedUcd = (Ucd)serializer.Deserialize(reader);
            }

            return cachedUcd.Repertoire.Char[charNum];
        }
    }
}
