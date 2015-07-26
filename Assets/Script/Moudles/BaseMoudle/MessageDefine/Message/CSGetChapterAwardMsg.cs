/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NetFramework.Auto
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CSGetChapterAwardMsg : TBase
  {
    private int _chapterId;
    private NetFramework.Auto.ChapterAward _chapterAward;

    public int ChapterId
    {
      get
      {
        return _chapterId;
      }
      set
      {
        __isset.chapterId = true;
        this._chapterId = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="NetFramework.Auto.ChapterAward"/>
    /// </summary>
    public NetFramework.Auto.ChapterAward ChapterAward
    {
      get
      {
        return _chapterAward;
      }
      set
      {
        __isset.chapterAward = true;
        this._chapterAward = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool chapterId;
      public bool chapterAward;
    }

    public CSGetChapterAwardMsg() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 10:
            if (field.Type == TType.I32) {
              ChapterId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              ChapterAward = (NetFramework.Auto.ChapterAward)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("CSGetChapterAwardMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.chapterId) {
        field.Name = "chapterId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ChapterId);
        oprot.WriteFieldEnd();
      }
      if (__isset.chapterAward) {
        field.Name = "chapterAward";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)ChapterAward);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSGetChapterAwardMsg(");
      sb.Append("ChapterId: ");
      sb.Append(ChapterId);
      sb.Append(",ChapterAward: ");
      sb.Append(ChapterAward);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
