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
  public partial class SCQueryArmyListMsg : TBase
  {
    private List<NetFramework.Auto.SimpleArmyInfo> _simpleArmyInfoList;

    public List<NetFramework.Auto.SimpleArmyInfo> SimpleArmyInfoList
    {
      get
      {
        return _simpleArmyInfoList;
      }
      set
      {
        __isset.simpleArmyInfoList = true;
        this._simpleArmyInfoList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool simpleArmyInfoList;
    }

    public SCQueryArmyListMsg() {
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
            if (field.Type == TType.List) {
              {
                SimpleArmyInfoList = new List<NetFramework.Auto.SimpleArmyInfo>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  NetFramework.Auto.SimpleArmyInfo _elem2 = new NetFramework.Auto.SimpleArmyInfo();
                  _elem2 = new NetFramework.Auto.SimpleArmyInfo();
                  _elem2.Read(iprot);
                  SimpleArmyInfoList.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("SCQueryArmyListMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SimpleArmyInfoList != null && __isset.simpleArmyInfoList) {
        field.Name = "simpleArmyInfoList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SimpleArmyInfoList.Count));
          foreach (NetFramework.Auto.SimpleArmyInfo _iter3 in SimpleArmyInfoList)
          {
            _iter3.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCQueryArmyListMsg(");
      sb.Append("SimpleArmyInfoList: ");
      sb.Append(SimpleArmyInfoList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
