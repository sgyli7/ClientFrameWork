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
  public partial class CSGiveMoneyToHeroRecruitMsg : TBase
  {
    private int _heroId;
    private sbyte _currencyType;
    private sbyte _giveIndex;

    public int HeroId
    {
      get
      {
        return _heroId;
      }
      set
      {
        __isset.heroId = true;
        this._heroId = value;
      }
    }

    /// <summary>
    /// 0、元宝，2、金币
    /// </summary>
    public sbyte CurrencyType
    {
      get
      {
        return _currencyType;
      }
      set
      {
        __isset.currencyType = true;
        this._currencyType = value;
      }
    }

    public sbyte GiveIndex
    {
      get
      {
        return _giveIndex;
      }
      set
      {
        __isset.giveIndex = true;
        this._giveIndex = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool heroId;
      public bool currencyType;
      public bool giveIndex;
    }

    public CSGiveMoneyToHeroRecruitMsg() {
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
              HeroId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Byte) {
              CurrencyType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Byte) {
              GiveIndex = iprot.ReadByte();
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
      TStruct struc = new TStruct("CSGiveMoneyToHeroRecruitMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.heroId) {
        field.Name = "heroId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(HeroId);
        oprot.WriteFieldEnd();
      }
      if (__isset.currencyType) {
        field.Name = "currencyType";
        field.Type = TType.Byte;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(CurrencyType);
        oprot.WriteFieldEnd();
      }
      if (__isset.giveIndex) {
        field.Name = "giveIndex";
        field.Type = TType.Byte;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(GiveIndex);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSGiveMoneyToHeroRecruitMsg(");
      sb.Append("HeroId: ");
      sb.Append(HeroId);
      sb.Append(",CurrencyType: ");
      sb.Append(CurrencyType);
      sb.Append(",GiveIndex: ");
      sb.Append(GiveIndex);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
