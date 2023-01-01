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
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yunikodo
{
    [XmlRoot(ElementName = "name-alias")]
    public class Namealias
    {

        [XmlAttribute(AttributeName = "alias")]
        public string Alias { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "char")]
    public class Char
    {

        [XmlElement(ElementName = "namealias")]
        public List<Namealias> Namealias { get; set; }

        [XmlAttribute(AttributeName = "cp")]
        public string Cp { get; set; }

        [XmlAttribute(AttributeName = "age")]
        public double Age { get; set; }

        [XmlAttribute(AttributeName = "gc")]
        public string Gc { get; set; }

        [XmlAttribute(AttributeName = "ccc")]
        public int Ccc { get; set; }

        [XmlAttribute(AttributeName = "dt")]
        public string Dt { get; set; }

        [XmlAttribute(AttributeName = "dm")]
        public string Dm { get; set; }

        [XmlAttribute(AttributeName = "JSN")]
        public string Jsn { get; set; }

        [XmlAttribute(AttributeName = "bmg")]
        public string Bmg { get; set; }

        [XmlAttribute(AttributeName = "isc")]
        public string Isc { get; set; }

        [XmlAttribute(AttributeName = "nt")]
        public string Nt { get; set; }

        [XmlAttribute(AttributeName = "nv")]
        public string Nv { get; set; }

        [XmlAttribute(AttributeName = "bc")]
        public string Bc { get; set; }

        [XmlAttribute(AttributeName = "bpt")]
        public string Bpt { get; set; }

        [XmlAttribute(AttributeName = "bpb")]
        public string Bpb { get; set; }

        [XmlAttribute(AttributeName = "Bidi_M")]
        public string BidiM { get; set; }

        [XmlAttribute(AttributeName = "suc")]
        public string Suc { get; set; }

        [XmlAttribute(AttributeName = "slc")]
        public string Slc { get; set; }

        [XmlAttribute(AttributeName = "stc")]
        public string Stc { get; set; }

        [XmlAttribute(AttributeName = "uc")]
        public string Uc { get; set; }

        [XmlAttribute(AttributeName = "lc")]
        public string Lc { get; set; }

        [XmlAttribute(AttributeName = "tc")]
        public string Tc { get; set; }

        [XmlAttribute(AttributeName = "scf")]
        public string Scf { get; set; }

        [XmlAttribute(AttributeName = "cf")]
        public string Cf { get; set; }

        [XmlAttribute(AttributeName = "jt")]
        public string Jt { get; set; }

        [XmlAttribute(AttributeName = "jg")]
        public string Jg { get; set; }

        [XmlAttribute(AttributeName = "ea")]
        public string Ea { get; set; }

        [XmlAttribute(AttributeName = "lb")]
        public string Lb { get; set; }

        [XmlAttribute(AttributeName = "sc")]
        public string Sc { get; set; }

        [XmlAttribute(AttributeName = "scx")]
        public string Scx { get; set; }

        [XmlAttribute(AttributeName = "Dash")]
        public string Dash { get; set; }

        [XmlAttribute(AttributeName = "WSpace")]
        public string WSpace { get; set; }

        [XmlAttribute(AttributeName = "Hyphen")]
        public string Hyphen { get; set; }

        [XmlAttribute(AttributeName = "QMark")]
        public string QMark { get; set; }

        [XmlAttribute(AttributeName = "Radical")]
        public string Radical { get; set; }

        [XmlAttribute(AttributeName = "Ideo")]
        public string Ideo { get; set; }

        [XmlAttribute(AttributeName = "UIdeo")]
        public string UIdeo { get; set; }

        [XmlAttribute(AttributeName = "IDSB")]
        public string IDSB { get; set; }

        [XmlAttribute(AttributeName = "IDST")]
        public string IDST { get; set; }

        [XmlAttribute(AttributeName = "hst")]
        public string Hst { get; set; }

        [XmlAttribute(AttributeName = "DI")]
        public string DI { get; set; }

        [XmlAttribute(AttributeName = "ODI")]
        public string ODI { get; set; }

        [XmlAttribute(AttributeName = "Alpha")]
        public string Alpha { get; set; }

        [XmlAttribute(AttributeName = "OAlpha")]
        public string OAlpha { get; set; }

        [XmlAttribute(AttributeName = "Upper")]
        public string Upper { get; set; }

        [XmlAttribute(AttributeName = "OUpper")]
        public string OUpper { get; set; }

        [XmlAttribute(AttributeName = "Lower")]
        public string Lower { get; set; }

        [XmlAttribute(AttributeName = "OLower")]
        public string OLower { get; set; }

        [XmlAttribute(AttributeName = "Math")]
        public string Math { get; set; }

        [XmlAttribute(AttributeName = "OMath")]
        public string OMath { get; set; }

        [XmlAttribute(AttributeName = "Hex")]
        public string Hex { get; set; }

        [XmlAttribute(AttributeName = "AHex")]
        public string AHex { get; set; }

        [XmlAttribute(AttributeName = "NChar")]
        public string NChar { get; set; }

        [XmlAttribute(AttributeName = "VS")]
        public string VS { get; set; }

        [XmlAttribute(AttributeName = "Bidi_C")]
        public string BidiC { get; set; }

        [XmlAttribute(AttributeName = "Join_C")]
        public string JoinC { get; set; }

        [XmlAttribute(AttributeName = "Gr_Base")]
        public string GrBase { get; set; }

        [XmlAttribute(AttributeName = "Gr_Ext")]
        public string GrExt { get; set; }

        [XmlAttribute(AttributeName = "OGr_Ext")]
        public string OGrExt { get; set; }

        [XmlAttribute(AttributeName = "Gr_Link")]
        public string GrLink { get; set; }

        [XmlAttribute(AttributeName = "STerm")]
        public string STerm { get; set; }

        [XmlAttribute(AttributeName = "Ext")]
        public string Ext { get; set; }

        [XmlAttribute(AttributeName = "Term")]
        public string Term { get; set; }

        [XmlAttribute(AttributeName = "Dia")]
        public string Dia { get; set; }

        [XmlAttribute(AttributeName = "Dep")]
        public string Dep { get; set; }

        [XmlAttribute(AttributeName = "IDS")]
        public string IDS { get; set; }

        [XmlAttribute(AttributeName = "OIDS")]
        public string OIDS { get; set; }

        [XmlAttribute(AttributeName = "XIDS")]
        public string XIDS { get; set; }

        [XmlAttribute(AttributeName = "IDC")]
        public string IDC { get; set; }

        [XmlAttribute(AttributeName = "OIDC")]
        public string OIDC { get; set; }

        [XmlAttribute(AttributeName = "XIDC")]
        public string XIDC { get; set; }

        [XmlAttribute(AttributeName = "SD")]
        public string SD { get; set; }

        [XmlAttribute(AttributeName = "LOE")]
        public string LOE { get; set; }

        [XmlAttribute(AttributeName = "Pat_WS")]
        public string PatWS { get; set; }

        [XmlAttribute(AttributeName = "Pat_Syn")]
        public string PatSyn { get; set; }

        [XmlAttribute(AttributeName = "GCB")]
        public string GCB { get; set; }

        [XmlAttribute(AttributeName = "WB")]
        public string WB { get; set; }

        [XmlAttribute(AttributeName = "SB")]
        public string SB { get; set; }

        [XmlAttribute(AttributeName = "CE")]
        public string CE { get; set; }

        [XmlAttribute(AttributeName = "Comp_Ex")]
        public string CompEx { get; set; }

        [XmlAttribute(AttributeName = "NFC_QC")]
        public string NFCQC { get; set; }

        [XmlAttribute(AttributeName = "NFD_QC")]
        public string NFDQC { get; set; }

        [XmlAttribute(AttributeName = "NFKC_QC")]
        public string NFKCQC { get; set; }

        [XmlAttribute(AttributeName = "NFKD_QC")]
        public string NFKDQC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFC")]
        public string XONFC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFD")]
        public string XONFD { get; set; }

        [XmlAttribute(AttributeName = "XO_NFKC")]
        public string XONFKC { get; set; }

        [XmlAttribute(AttributeName = "XO_NFKD")]
        public string XONFKD { get; set; }

        [XmlAttribute(AttributeName = "FC_NFKC")]
        public string FCNFKC { get; set; }

        [XmlAttribute(AttributeName = "CI")]
        public string CI { get; set; }

        [XmlAttribute(AttributeName = "Cased")]
        public string Cased { get; set; }

        [XmlAttribute(AttributeName = "CWCF")]
        public string CWCF { get; set; }

        [XmlAttribute(AttributeName = "CWCM")]
        public string CWCM { get; set; }

        [XmlAttribute(AttributeName = "CWKCF")]
        public string CWKCF { get; set; }

        [XmlAttribute(AttributeName = "CWL")]
        public string CWL { get; set; }

        [XmlAttribute(AttributeName = "CWT")]
        public string CWT { get; set; }

        [XmlAttribute(AttributeName = "CWU")]
        public string CWU { get; set; }

        [XmlAttribute(AttributeName = "NFKC_CF")]
        public string NFKCCF { get; set; }

        [XmlAttribute(AttributeName = "InSC")]
        public string InSC { get; set; }

        [XmlAttribute(AttributeName = "InPC")]
        public string InPC { get; set; }

        [XmlAttribute(AttributeName = "PCM")]
        public string PCM { get; set; }

        [XmlAttribute(AttributeName = "vo")]
        public string Vo { get; set; }

        [XmlAttribute(AttributeName = "RI")]
        public string RI { get; set; }

        [XmlAttribute(AttributeName = "blk")]
        public string Blk { get; set; }

        [XmlAttribute(AttributeName = "na1")]
        public string Na1 { get; set; }

        [XmlAttribute(AttributeName = "na")]
        public string Na { get; set; }

        [XmlAttribute(AttributeName = "Emoji")]
        public string Emoji { get; set; }

        [XmlAttribute(AttributeName = "EPres")]
        public string EPres { get; set; }

        [XmlAttribute(AttributeName = "EMod")]
        public string EMod { get; set; }

        [XmlAttribute(AttributeName = "EBase")]
        public string EBase { get; set; }

        [XmlAttribute(AttributeName = "EComp")]
        public string EComp { get; set; }

        [XmlAttribute(AttributeName = "ExtPict")]
        public string ExtPict { get; set; }
    }

    [XmlRoot(ElementName = "repertoire")]
    public class Repertoire
    {

        [XmlElement(ElementName = "char")]
        public Char[] Char { get; set; }
    }

    [XmlRoot(ElementName = "ucd")]
    public class Ucd
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "repertoire")]
        public Repertoire Repertoire { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
