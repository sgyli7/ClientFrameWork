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
  public partial class CSUpdateArmyBulletinBoardContentMsg : TBase
  {
    private string _bulletinBoardContent;

    public string BulletinBoardContent
    {
      get
      {
        return _bulletinBoardContent;
      }
      set
      {
        __isset.bulletinBoardContent = true;
        this._bulletinBoardContent = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool bulletinBoardContent;
    }

    public CSUpdateArmyBulletinBoardContentMsg() {
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
            if (field.Type == TType.String) {
              BulletinBoardContent = iprot.ReadString();
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
      TStruct struc = new TStruct("CSUpdateArmyBulletinBoardContentMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BulletinBoardContent != null && __isset.bulletinBoardContent) {
        field.Name = "bulletinBoardContent";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(BulletinBoardContent);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSUpdateArmyBulletinBoardContentMsg(");
      sb.Append("BulletinBoardContent: ");
      sb.Append(BulletinBoardContent);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
