// <copyright file="DataType.cs" company="ContextQuickie">
// MIT License
//
// Copyright (c) 2018
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
namespace FritzControl.Tr064
{
  using System.Xml.Serialization;

  /// <summary>
  /// Enumeration of data types for a <see cref="ServiceStateVariable"/>.
  /// </summary>
  public enum DataType
  {
    /// <summary>
    /// Unsigned integer, 1 byte.
    /// </summary>
    [XmlEnum("ui1")]
    UnsignedInt1Byte,

    /// <summary>
    /// Unsigned integer, 2 bytes.
    /// </summary>
    [XmlEnum("ui2")]
    UnsignedInt2Bytes,

    /// <summary>
    /// Unsigned integer, 4 bytes.
    /// </summary>
    [XmlEnum("ui4")]
    UnsignedInt4Bytes,

    /// <summary>
    /// Signed integer, 1 byte.
    /// </summary>
    [XmlEnum("i1")]
    SignedInt1Byte,

    /// <summary>
    /// Signed integer, 2 bytes.
    /// </summary>
    [XmlEnum("i2")]
    SignedInt2Bytes,

    /// <summary>
    /// Signed integer, 4 bytes.
    /// </summary>
    [XmlEnum("i4")]
    SignedInt4Bytes,

    /// <summary>
    /// Integer number.
    /// </summary>
    [XmlEnum("int")]
    Integer,

    /// <summary>
    /// Float, 4 bytes.
    /// </summary>
    [XmlEnum("r4")]
    Float4Bytes,

    /// <summary>
    /// Float, 8 bytes.
    /// </summary>
    [XmlEnum("r8")]
    Float8Bytes,

    /// <summary>
    /// Same as <see cref="Float8Bytes"/>.
    /// </summary>
    [XmlEnum("number")]
    Number,

    /// <summary>
    /// Same as <see cref="Float8Bytes"/> but no more than 14 digits to the left of the decimal point and no more than 4 to the right.
    /// </summary>
    [XmlEnum("fixed.14.4")]
    Fixed_14_4,

    /// <summary>
    /// Float value.
    /// </summary>
    [XmlEnum("float")]
    Float,

    /// <summary>
    /// One unicode character.
    /// </summary>
    [XmlEnum("char")]
    Char,

    /// <summary>
    /// A unicode string.
    /// </summary>
    [XmlEnum("string")]
    String,

    /// <summary>
    /// A date without time information.
    /// </summary>
    [XmlEnum("date")]
    Date,

    /// <summary>
    /// A date with time information.
    /// </summary>
    [XmlEnum("dateTime")]
    DateTime,

    /// <summary>
    /// A date with time information and optional time zone information.
    /// </summary>
    [XmlEnum("dateTime.tz")]
    DateTimeWithTimeZone,

    /// <summary>
    /// A time without date information.
    /// </summary>
    [XmlEnum("time")]
    Time,

    /// <summary>
    /// A time without date information.
    /// </summary>
    [XmlEnum("time.tz")]
    TimeWithTimeZone,

    /// <summary>
    /// “0” for false or “1” for true. The values “true”, “yes”, “false”, or “no” are deprecated and MUST NOT be sent but MUST be accepted when received.
    /// When received, the values “true” and “yes” MUST be interpreted as true and the values “false” and “no” MUST be interpreted as false.
    /// </summary>
    [XmlEnum("boolean")]
    Boolean,

    /// <summary>
    /// MIME-style Base64 encoded binary BLOB. Takes 3 Bytes, splits them into 4 parts, and maps each 6 bit piece to an octet. (3 octets are encoded as 4.) No limit on size.
    /// </summary>
    [XmlEnum("bin.base64")]
    Base64Binary,

    /// <summary>
    /// Hexadecimal digits representing octets. Treats each nibble as a hex digit and encodes as a separate Byte. (1 octet is encoded as 2.) No limit on size.
    /// </summary>
    [XmlEnum("bin.hex")]
    HexBinary,

    /// <summary>
    /// An URI.
    /// </summary>
    [XmlEnum("uri")]
    URI,

    /// <summary>
    /// An UUID.
    /// </summary>
    [XmlEnum("uuid")]
    UUID,
  }
}
