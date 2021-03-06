using System;
using System.Collections.Generic;
using System.Text;

interface PacketWriter
{
  void WriteUInt(uint v, int l);
  void WriteULong(ulong v);
  void WriteInt(int v, int l);
  void WriteLong(long v);
  void WriteString(string v);
  void WriteString(string v, int length);
  void WriteData(byte[] v, int offset, int length);
  void WriteData(byte[] v, int length);

  void WriteUInt8(int v);
  void WriteUInt16(int v);
  void WriteUInt32(int v);
  void WriteUInt64(long v);

  void WriteInt8(int v);
  void WriteInt16(int v);
  void WriteInt32(int v);
  void WriteInt64(long v);

  void WriteFloat(float v);
  void WriteDouble(double v);
}
