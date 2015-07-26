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
  public partial class SCExecFuncMsg : TBase
  {
    private int _sceneId;
    private int _funcId;
    private long _thisUniqueId;
    private List<long> _targetUniqueIdList;
    private NetFramework.Auto.FuncContext _context;

    public int SceneId
    {
      get
      {
        return _sceneId;
      }
      set
      {
        __isset.sceneId = true;
        this._sceneId = value;
      }
    }

    public int FuncId
    {
      get
      {
        return _funcId;
      }
      set
      {
        __isset.funcId = true;
        this._funcId = value;
      }
    }

    public long ThisUniqueId
    {
      get
      {
        return _thisUniqueId;
      }
      set
      {
        __isset.thisUniqueId = true;
        this._thisUniqueId = value;
      }
    }

    public List<long> TargetUniqueIdList
    {
      get
      {
        return _targetUniqueIdList;
      }
      set
      {
        __isset.targetUniqueIdList = true;
        this._targetUniqueIdList = value;
      }
    }

    public NetFramework.Auto.FuncContext Context
    {
      get
      {
        return _context;
      }
      set
      {
        __isset.context = true;
        this._context = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sceneId;
      public bool funcId;
      public bool thisUniqueId;
      public bool targetUniqueIdList;
      public bool context;
    }

    public SCExecFuncMsg() {
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
              SceneId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              FuncId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I64) {
              ThisUniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.List) {
              {
                TargetUniqueIdList = new List<long>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  long _elem2 = 0;
                  _elem2 = iprot.ReadI64();
                  TargetUniqueIdList.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.Struct) {
              Context = new NetFramework.Auto.FuncContext();
              Context.Read(iprot);
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
      TStruct struc = new TStruct("SCExecFuncMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.sceneId) {
        field.Name = "sceneId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SceneId);
        oprot.WriteFieldEnd();
      }
      if (__isset.funcId) {
        field.Name = "funcId";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(FuncId);
        oprot.WriteFieldEnd();
      }
      if (__isset.thisUniqueId) {
        field.Name = "thisUniqueId";
        field.Type = TType.I64;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(ThisUniqueId);
        oprot.WriteFieldEnd();
      }
      if (TargetUniqueIdList != null && __isset.targetUniqueIdList) {
        field.Name = "targetUniqueIdList";
        field.Type = TType.List;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, TargetUniqueIdList.Count));
          foreach (long _iter3 in TargetUniqueIdList)
          {
            oprot.WriteI64(_iter3);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Context != null && __isset.context) {
        field.Name = "context";
        field.Type = TType.Struct;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        Context.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCExecFuncMsg(");
      sb.Append("SceneId: ");
      sb.Append(SceneId);
      sb.Append(",FuncId: ");
      sb.Append(FuncId);
      sb.Append(",ThisUniqueId: ");
      sb.Append(ThisUniqueId);
      sb.Append(",TargetUniqueIdList: ");
      sb.Append(TargetUniqueIdList);
      sb.Append(",Context: ");
      sb.Append(Context== null ? "<null>" : Context.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
