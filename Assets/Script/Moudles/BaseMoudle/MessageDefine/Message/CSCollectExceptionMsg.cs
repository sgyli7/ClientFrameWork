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
  public partial class CSCollectExceptionMsg : TBase
  {
    private List<NetFramework.Auto.ErrorInfo> _exceptionList;

    public List<NetFramework.Auto.ErrorInfo> ExceptionList
    {
      get
      {
        return _exceptionList;
      }
      set
      {
        __isset.exceptionList = true;
        this._exceptionList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool exceptionList;
    }

    public CSCollectExceptionMsg() {
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
                ExceptionList = new List<NetFramework.Auto.ErrorInfo>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  NetFramework.Auto.ErrorInfo _elem2 = new NetFramework.Auto.ErrorInfo();
                  _elem2 = new NetFramework.Auto.ErrorInfo();
                  _elem2.Read(iprot);
                  ExceptionList.Add(_elem2);
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
      TStruct struc = new TStruct("CSCollectExceptionMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ExceptionList != null && __isset.exceptionList) {
        field.Name = "exceptionList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ExceptionList.Count));
          foreach (NetFramework.Auto.ErrorInfo _iter3 in ExceptionList)
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
      StringBuilder sb = new StringBuilder("CSCollectExceptionMsg(");
      sb.Append("ExceptionList: ");
      sb.Append(ExceptionList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
