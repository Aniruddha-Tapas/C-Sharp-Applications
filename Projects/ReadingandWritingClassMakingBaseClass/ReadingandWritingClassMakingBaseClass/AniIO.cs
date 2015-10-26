using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AniIO
{
    public class Reader : BaseIO
    {
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">Path to the file to read</param>
        public Reader(string path)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = ByteOrder.BigEndian;
        }
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">Path to the file to read</param>
        /// <param name="bo">Order of the bytes to read</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = bo;
        }

        BinaryReader br;
        
        /// <summary>
        /// The position to read at
        /// </summary>
        public long Position {
            get { return br.BaseStream.Position; }
            set{ br.BaseStream.Position = value;}
        }

        /// <summary>
        /// Increments the current position of the byte reader by one.
        /// </summary>
        /// <returns></returns>
        public byte ReadByte() 
        {
            return br.ReadByte();
        }
        /// <summary>
        /// Signed Byte.
        /// </summary>
        /// <returns></returns>
        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte();
        }

        public short ReadInt16()
        {
            short myShort = br.ReadInt16();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myShort);
                Array.Reverse(buff);
                myShort = BitConverter.ToInt16(buff, 0); //read 78 65 which originally read 65 78
            }
            return myShort;
            // 78 65
        }
        
        public ushort ReadUInt16()
        {
            ushort myuShort = br.ReadUInt16();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myuShort);
                Array.Reverse(buff);
                myuShort = BitConverter.ToUInt16(buff, 0); 
            }
            return myuShort;
        }

        public int ReadInt32()
        {
            int myInt = br.ReadInt32();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myInt);
                Array.Reverse(buff);
                myInt = BitConverter.ToInt32(buff, 0); 
            }
            return myInt;
        }

        public uint ReadUInt32()
        {
            uint myUInt = br.ReadUInt32();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myUInt);
                Array.Reverse(buff);
                myUInt = BitConverter.ToUInt32(buff, 0);
            }
            return myUInt;
        }

        public long ReadInt64()
        {
            long myLong = br.ReadInt64();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myLong);
                Array.Reverse(buff);
                myLong = BitConverter.ToInt64(buff, 0);
            }
            return myLong;
        }

        public ulong ReadUInt64()
        {
            ulong myULong = br.ReadUInt64();
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myULong);
                Array.Reverse(buff);
                myULong = BitConverter.ToUInt64(buff, 0);
            }
            return myULong;
        }

        public byte[] ReadBytes(int amount)
        {
            byte[] buffer = br.ReadBytes(amount);
            if (byteorder == ByteOrder.LittleEndian)
                Array.Reverse(buffer);
            return buffer;
        }

        public void Close()
        {
            br.Close();
        }

        public string ReadString(int length)
        {
            return new string(br.ReadChars(length));
        }

        public string ReadUnicodeString(int length)
        {
            if (byteorder == ByteOrder.BigEndian)
                return Encoding.BigEndianUnicode.GetString(br.ReadBytes(length));
            else
                return Encoding.Unicode.GetString(br.ReadBytes(length));
        }

        public char ReadChar()
        {
            return br.ReadChar();
        }

        public char[] ReadChars(int amount)
        {
            return br.ReadChars(amount);
        }
    }

    public class Writer : BaseIO
    {
        BinaryWriter bw;

        public Writer(string path)
        {
            bw = new BinaryWriter(File.OpenWrite(path));
            byteorder = ByteOrder.BigEndian;
        }

        public Writer(string path, ByteOrder bo)
        {
            bw = new BinaryWriter(File.OpenWrite(path));
            byteorder = bo;
        }

        public long Position
        {
            get { return bw.BaseStream.Position; }
            set { bw.BaseStream.Position = value; }
        }

        public void WriteByte(byte toWrite)
        {
            bw.Write(toWrite);
        }

        public void WriteBytes(byte[] bytesToWrite)  //FF FE
        {
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(bytesToWrite);
            bw.Write(bytesToWrite);
        }

        public void WriteInt16(short toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteUInt16(ushort toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteInt32(int toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteUInt32(uint toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteInt64(long toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteUInt64(ulong toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
                Array.Reverse(buffer);
            bw.Write(buffer);
        }

        public void WriteString(string toWrite)
        {
            bw.Write(toWrite.ToCharArray());
        }

        public void WriteUnicodeString(string toWrite)
        {
            byte[] buffer = (byteorder == ByteOrder.BigEndian) ? Encoding.BigEndianUnicode.GetBytes(toWrite) : Encoding.Unicode.GetBytes(toWrite);
            bw.Write(buffer);
        }

        public void WriteCharacter(char toWrite)
        {
            bw.Write(toWrite);
        }

        public void WriteCharacter(char[] toWrite)
        {
            bw.Write(toWrite);
        }

        public void Close()
        {
            bw.Close();
        }
    }

    public abstract class BaseIO
    {
        /// <summary>
        /// The order of the bytes both read and written
        /// </summary>
        public enum ByteOrder
        { 
            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteorder;

        public void ChangeByteOrder(ByteOrder bo)
        {
            this.byteorder = bo;
        }
    }
}
