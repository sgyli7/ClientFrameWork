﻿using UnityEngine;
using System;
using Object = UnityEngine.Object;

public class Debuger
{
    public static   bool                    IsEnableLog { get; set; }
    private static  Action<string>          m_OnLogTriggerCallBack;
    public static void Initialize(Action<string> OnLogTriggerCallBack, bool isEnalbeLog = true)
    {
        IsEnableLog     = isEnalbeLog;
        Application.RegisterLogCallback(HandleLog);
        m_OnLogTriggerCallBack = OnLogTriggerCallBack;
    }
    public static void Log(object message)
    {
        if (IsEnableLog)
        {
            Debug.Log(message);
        }
        RecordLog(message);
    }
    public static void Log(object message, Object context)
    {
        if (IsEnableLog)
        {
            Debug.Log(message, context);
        }
        RecordLog(message);
    }
    public static void LogWarning(object message)
    {
        if (IsEnableLog)
        {
            Debug.LogWarning(message);
        }
        RecordLog(message);
    }
    public static void LogWarning(object message, Object context)
    {
        if (IsEnableLog)
        {
            Debug.LogWarning(message, context);
        }
        RecordLog(message);
    }
    public static void LogError(object message)
    {
        if (IsEnableLog)
        {
            Debug.LogError(message);
        }
        RecordLog(message);
    }
    public static void LogError(object message, Object context)
    {
        if (IsEnableLog)
        {
            Debug.LogError(message, context);
        }
        RecordLog(message);
    }
    private static void HandleLog(string condition, string stacktrace, LogType type)
    {
        if (type == LogType.Assert || type == LogType.Exception)
        {
            RecordLog(condition + " " + stacktrace);
        }
    }
    private static void RecordLog(object messsage)
    {
        m_OnLogTriggerCallBack(messsage as string);
    }
}