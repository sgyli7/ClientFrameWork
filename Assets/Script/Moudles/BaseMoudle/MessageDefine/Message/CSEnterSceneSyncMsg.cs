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
  public partial class CSEnterSceneSyncMsg : TBase
  {
    private Common.Auto.ThriftVector3 _position;
    private Common.Auto.ThriftVector3 _rotation;
    private int _sceneId;

    public Common.Auto.ThriftVector3 Position
    {
      get
      {
        return _position;
      }
      set
      {
        __isset.position = true;
        this._position = value;
      }
    }

    public Common.Auto.ThriftVector3 Rotation
    {
      get
      {
        return _rotation;
      }
      set
      {
        __isset.rotation = true;
        this._rotation = value;
      }
    }

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


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool position;
      public bool rotation;
      public bool sceneId;
    }

    public CSEnterSceneSyncMsg() {
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
            if (field.Type == TType.Struct) {
              Position = new Common.Auto.ThriftVector3();
              Position.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Struct) {
              Rotation = new Common.Auto.ThriftVector3();
              Rotation.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              SceneId = iprot.ReadI32();
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
      TStruct struc = new TStruct("CSEnterSceneSyncMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Position != null && __isset.position) {
        field.Name = "position";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        Position.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Rotation != null && __isset.rotation) {
        field.Name = "rotation";
        field.Type = TType.Struct;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        Rotation.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.sceneId) {
        field.Name = "sceneId";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SceneId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSEnterSceneSyncMsg(");
      sb.Append("Position: ");
      sb.Append(Position== null ? "<null>" : Position.ToString());
      sb.Append(",Rotation: ");
      sb.Append(Rotation== null ? "<null>" : Rotation.ToString());
      sb.Append(",SceneId: ");
      sb.Append(SceneId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
