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

  /// <summary>
  /// 任务信息
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SCMissionInfo : TBase
  {
    private int _missionId;
    private sbyte _missionState;
    private sbyte _stepIndex;
    private SCMissionStepInfo _scMissionStepInfo;

    public int MissionId
    {
      get
      {
        return _missionId;
      }
      set
      {
        __isset.missionId = true;
        this._missionId = value;
      }
    }

    public sbyte MissionState
    {
      get
      {
        return _missionState;
      }
      set
      {
        __isset.missionState = true;
        this._missionState = value;
      }
    }

    /// <summary>
    /// 步骤索引
    /// </summary>
    public sbyte StepIndex
    {
      get
      {
        return _stepIndex;
      }
      set
      {
        __isset.stepIndex = true;
        this._stepIndex = value;
      }
    }

    public SCMissionStepInfo ScMissionStepInfo
    {
      get
      {
        return _scMissionStepInfo;
      }
      set
      {
        __isset.scMissionStepInfo = true;
        this._scMissionStepInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool missionId;
      public bool missionState;
      public bool stepIndex;
      public bool scMissionStepInfo;
    }

    public SCMissionInfo() {
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
              MissionId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Byte) {
              MissionState = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Byte) {
              StepIndex = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Struct) {
              ScMissionStepInfo = new SCMissionStepInfo();
              ScMissionStepInfo.Read(iprot);
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
      TStruct struc = new TStruct("SCMissionInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.missionId) {
        field.Name = "missionId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MissionId);
        oprot.WriteFieldEnd();
      }
      if (__isset.missionState) {
        field.Name = "missionState";
        field.Type = TType.Byte;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(MissionState);
        oprot.WriteFieldEnd();
      }
      if (__isset.stepIndex) {
        field.Name = "stepIndex";
        field.Type = TType.Byte;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(StepIndex);
        oprot.WriteFieldEnd();
      }
      if (ScMissionStepInfo != null && __isset.scMissionStepInfo) {
        field.Name = "scMissionStepInfo";
        field.Type = TType.Struct;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        ScMissionStepInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCMissionInfo(");
      sb.Append("MissionId: ");
      sb.Append(MissionId);
      sb.Append(",MissionState: ");
      sb.Append(MissionState);
      sb.Append(",StepIndex: ");
      sb.Append(StepIndex);
      sb.Append(",ScMissionStepInfo: ");
      sb.Append(ScMissionStepInfo== null ? "<null>" : ScMissionStepInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
