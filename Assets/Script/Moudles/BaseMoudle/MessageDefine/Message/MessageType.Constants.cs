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

namespace NetFramework.Auto
{
  public static class MessageTypeConstants
  {
    public static int IN_ASYNC_TASK = 1000;
    public static int IN_CHANNEL_STATE = 1001;
    public static int IN_GM_COMMAND = 1002;
    public static int IN_SHUTDOWM = 1003;
    public static int IN_SHUTDOWN_KICK_ALL_PLAYER = 1004;
    public static int IN_STOP_MAIN_THREAD = 1005;
    public static int C_SOCKET_OPEN = 5000;
    public static int C_SOCKET_CLOSE = 5001;
    public static int C_UNKONW_THRIFT_SC_MESSAGE = 5002;
    public static int C_UNKONW_THRIFT_CS_MESSAGE = 5003;
    public static int C_SEND_FAIL_MESSAGE = 5004;
    public static int C_CANT_CONNECT_SERVER = 5005;
    public static int C_RECEIVE_TIMEOUT = 5006;
    public static int C_CLOSE_LOADING_FRAME = 5007;
    public static int CS_REGISTER = 100001;
    public static int CS_LOGIN = 100002;
    public static int CS_CREATE_NEW_CHAR = 100003;
    public static int CS_QUERY_CHARACTER_INFO = 100004;
    public static int CS_PING = 100005;
    public static int CS_RANDOM_NAME = 100006;
    public static int CS_BAG_INFO = 100007;
    public static int CS_COLLECT_EXCEPTION = 100501;
    public static int CS_QUERY_MAIL_LIST = 101001;
    public static int CS_MARK_MAIL = 101002;
    public static int CS_HERO_STAR_LEVEL_UP = 102001;
    public static int CS_HERO_QUALITY_LEVEL_UP = 102002;
    public static int CS_HERO_SKILL_LEVEL_UP = 102003;
    public static int CS_HERO_SKILL_QUALITY_LEVEL_UP = 102004;
    public static int CS_SYNTHETIC_HERO = 102005;
    public static int CS_SYNC_HERO_GROUP = 102006;
    public static int CS_PLAY_FINGER_GUESSING = 102007;
    public static int CS_QUERY_HERO_RECRUIT_LIST = 102008;
    public static int CS_REFRESH_HERO_RECRUIT_LIST = 102009;
    public static int CS_GIVE_GIFT_TO_HERO_RECRUIT = 102010;
    public static int CS_GIVE_MONEY_TO_HERO_RECRUIT = 102011;
    public static int CS_RECRUIT_HERO = 102012;
    public static int CS_PUT_ON_HERO_EQUIPMENT = 102013;
    public static int CS_TAKE_OFF_HERO_EQUIPMENT = 102014;
    public static int CS_BUY_HERO_SKILL_POINT = 102015;
    public static int CS_SHARE_HERO = 102016;
    public static int CS_CHARACTER_RENAME = 103001;
    public static int CS_SYNC_PUTON_SKILL = 103002;
    public static int CS_CHAR_SKILL_LEVEL_UP = 103003;
    public static int CS_HERO_EQUIPMENT_ENHANCE = 103004;
    public static int CS_CHAR_EQUIPMENT_BRING_UP = 103005;
    public static int CS_INLAY_GEM = 103006;
    public static int CS_REMOVE_GEM = 103007;
    public static int CS_CHAR_EQUIPMENT_LEVEL_UP = 103008;
    public static int CS_QUICK_COMPLETE_EQUIPMENT_BRING_UP = 103009;
    public static int CS_CANCEL_EQUIPMENT_BRING_UP = 103010;
    public static int CS_CHAT = 104001;
    public static int CS_CHAT_SETTING = 104002;
    public static int CS_USE_ITEM = 105001;
    public static int CS_STAGE_QUICK_WIN = 106001;
    public static int CS_GET_CHAPTER_AWARD = 106002;
    public static int CS_ENTER_STAGE = 106003;
    public static int CS_BATTLE_END = 106004;
    public static int CS_BEGIN_LOAD_STAGE = 106005;
    public static int CS_END_LOAD_STAGE = 106006;
    public static int CS_END_SHOW_EFFECT = 106007;
    public static int CS_CHANGE_BATTLE_MODE = 106008;
    public static int CS_EXIT_STAGE = 106009;
    public static int CS_SWITCH_HERO = 106010;
    public static int CS_MOVE_TO = 106011;
    public static int CS_PRE_USE_SKILL = 106012;
    public static int CS_USE_SKILL = 106013;
    public static int CS_SWITCH_TARGET = 106014;
    public static int CS_FOCUS_TARGET = 106015;
    public static int CS_SUSPEND_BATTLE = 106016;
    public static int CS_RESUME_BATTLE = 106017;
    public static int CS_EXEC_TRIGGER = 106018;
    public static int CS_PICK_UP_ITEM = 106019;
    public static int CS_ACCEPT_MISSION = 107001;
    public static int CS_COMPLETE_MISSION = 107002;
    public static int CS_COMPLETE_MISSION_STEP = 107003;
    public static int CS_ENTER_SCENE_SYNC = 108001;
    public static int CS_EXIT_SCENE_SYNC = 108002;
    public static int CS_SCENE_CHARINFO_SYNC = 108003;
    public static int CS_CREATE_ARMY = 109001;
    public static int CS_QUERY_ARMY_LIST = 109002;
    public static int CS_SEARCH_ARMY = 109003;
    public static int CS_QUERY_APPLY_JOIN_ARMY_LIST = 109004;
    public static int CS_APPLY_JOIN_ARMY = 109005;
    public static int CS_HANDLE_APPLY_JOIN = 109006;
    public static int CS_EXIT_ARMY = 109007;
    public static int CS_KICK_EXIT_ARMY = 109008;
    public static int CS_APPLY_DISBAND_ARMY = 109009;
    public static int CS_CANCEL_DISBAND_ARMY = 109010;
    public static int CS_CLEAR_APPLY_JOIN_LIST = 109011;
    public static int CS_MODIFY_ARMY_MEMBER_ROLE = 19012;
    public static int CS_UPDATE_ARMY_BULLETIN_BOARD_CONTENT = 19013;
    public static int CS_ADD_FRIEND = 110001;
    public static int CS_DELETE_FRIEND = 110002;
    public static int CS_ADD_BLACKNAME = 110003;
    public static int CS_DELETE_BLACKNAME = 110004;
    public static int CS_SELECT_FRIEND = 110005;
    public static int CS_SHOW_FRIEND = 110006;
    public static int CS_REFLESH_RECOMMEND_FRIEND = 110007;
    public static int CS_SEND_FRIEND_GIFT = 110008;
    public static int SC_REGISTER = 200001;
    public static int SC_LOGIN = 200002;
    public static int SC_NOTICE_CREATE_NEW_CHAR = 200003;
    public static int SC_CREATE_NEW_CHAR = 200004;
    public static int SC_SYSTEM_INFO = 200005;
    public static int SC_CHARACTER_INFO = 200006;
    public static int SC_PING = 200007;
    public static int SC_RANDOM_NAME = 200008;
    public static int SC_RELOGIN = 200009;
    public static int SC_BAG_INFO = 200010;
    public static int SC_SERVER_INFO = 200011;
    public static int SC_SYNC_HERO_GROUP = 200012;
    public static int SC_ENTER_GAME = 200013;
    public static int SC_QUERY_MAIL_LIST = 201001;
    public static int SC_NEW_MAIL = 201002;
    public static int SC_CHARACTER_RENAME = 203001;
    public static int SC_SYNC_CHARACTER_PROPERTY = 203002;
    public static int SC_ADD_HERO = 203003;
    public static int SC_ADD_PROPS = 203004;
    public static int SC_CHANGE_PROPS_COUNT = 203005;
    public static int SC_EXEC_FUNC = 203006;
    public static int SC_PLAY_FINGER_GUESSING = 203007;
    public static int SC_ADD_HERO_EQUIPMENT = 203008;
    public static int SC_CHAR_EQUIPMENT_BRING_UP = 203009;
    public static int SC_CHAR_EQUIPMENT_BRING_UP_COMPLATE = 203010;
    public static int SC_INLAY_GEM = 203011;
    public static int SC_REMOVE_GEM = 203012;
    public static int SC_ADD_GEM = 203013;
    public static int SC_CANCEL_EQUIPMENT_BRING_UP = 203014;
    public static int SC_CHAT = 204001;
    public static int SC_CHAT_RESULT = 204002;
    public static int SC_HERO_STAR_LEVEL_UP = 205001;
    public static int SC_HERO_QUALITY_LEVEL_UP = 205002;
    public static int SC_HERO_SKILL_QUALITY_LEVEL_UP = 205003;
    public static int SC_SYNTHETIC_HERO = 205004;
    public static int SC_HERO_RECRUIT_PROGRESS = 205005;
    public static int SC_HERO_RECRUIT_LIST = 205006;
    public static int SC_RECRUIT_HERO = 205007;
    public static int SC_PUT_ON_HERO_EQUIPMENT = 205008;
    public static int SC_TAKE_OFF_HERO_EQUIPMENT = 205009;
    public static int SC_GIVE_GIFT_TO_HERO_RECRUIT = 205010;
    public static int SC_GIVE_MONEY_TO_HERO_RECRUIT = 205011;
    public static int SC_CHAR_EQUIPMENT_LEVEL_UP = 205012;
    public static int SC_BUY_HERO_SKILL_POINT = 205013;
    public static int SC_USE_ITEM = 206001;
    public static int SC_STAGE_QUICK_WIN = 207001;
    public static int SC_GET_CHAPTER_AWARD = 207002;
    public static int SC_STAGE_INFO = 207003;
    public static int SC_BATTLE_RESULT = 207004;
    public static int SC_BEGIN_LOAD_STAGE = 207005;
    public static int SC_ENTER_STAGE = 207006;
    public static int SC_START_BATTLE = 207007;
    public static int SC_EXIT_STAGE = 207008;
    public static int SC_REFRESH_MONSTER = 207009;
    public static int SC_MONSTER_DEATH = 207010;
    public static int SC_BATTLE_FINISH = 207011;
    public static int SC_HERO_DEATH = 207012;
    public static int SC_MOVE_TO = 207013;
    public static int SC_ADJUST_POS = 207014;
    public static int SC_PRE_USE_SKILL = 207015;
    public static int SC_USE_SKILL = 207016;
    public static int SC_CANCEL_SKILL = 207017;
    public static int SC_LIFE_ENTER_STATE = 207018;
    public static int SC_ADD_BUFF = 207019;
    public static int SC_TICK_BUFF = 207020;
    public static int SC_DEL_BUFF = 207021;
    public static int SC_SYNC_BATTLE_LIFE_INFO = 207022;
    public static int SC_FOCUS_TARGET = 207023;
    public static int SC_PUTON_AURA = 207024;
    public static int SC_TAKEOFF_AURA = 207025;
    public static int SC_TICK_AURA = 207026;
    public static int SC_LEAVE_AURA = 207027;
    public static int SC_TICK_TRIGGER = 207028;
    public static int SC_LEAVE_TRIGGER = 207029;
    public static int SC_CREATE_TRIGGER = 207030;
    public static int SC_DELETE_TRIGGER = 207031;
    public static int SC_BEAT_BACK = 207032;
    public static int SC_TOGGLE_TRIGGER = 207033;
    public static int SC_DROP_ITEM = 207034;
    public static int SC_ACCEPT_MISSION = 208001;
    public static int SC_COMPLETE_MISSION = 208002;
    public static int SC_COMPLETE_MISSION_STEP = 208003;
    public static int SC_MISSION_INFO_LIST = 208004;
    public static int SC_ENTER_SCENE_SYNC = 209001;
    public static int SC_EXIT_SCENE_SYNC = 209002;
    public static int SC_SCENE_CHARINFO_SYNC = 209003;
    public static int SC_SINGLE_SCENE_CHARINFO_SYNC = 209004;
    public static int SC_CREATE_ARMY = 210001;
    public static int SC_QUERY_ARMY_LIST = 210002;
    public static int SC_SEARCH_ARMY = 210003;
    public static int SC_ARMY_INFO = 210004;
    public static int SC_ARMY_INFO_CHANGE = 210005;
    public static int SC_ARMY_MEMBER_INFO_CHANGE = 210006;
    public static int SC_QUERY_APPLY_JOIN_ARMY_LIST = 210007;
    public static int SC_APPLY_JOIN_ARMY = 210008;
    public static int SC_CHARACTER_JOIN_ARMY = 210009;
    public static int SC_EXIT_ARMY = 210010;
    public static int SC_CHARACTER_LEAVE_ARMY = 210011;
    public static int SC_KICK_EXIT_ARMY = 210012;
    public static int SC_APPLY_DISBAND_ARMY = 210013;
    public static int SC_CANCEL_DISBAND_ARMY = 210014;
    public static int SC_NOTICE_ARMY_DISBAND = 210015;
    public static int SC_NOTICE_HANLE_APPLY_JOIN = 210016;
    public static int SC_FRIEND_LIST = 211001;
    public static int SC_REFLESH_RECOMMEND_FRIEND = 211002;
    public static int SC_ADD_FRIEND = 211003;
    public static int SC_DELETE_FRIEND = 211004;
    public static int SC_ADD_BLACKNAME = 211005;
    public static int SC_DELETE_BLACKNAME = 211006;
    public static int SC_SELECT_FRIEND = 211007;
    public static int SC_SHOW_FRIEND = 211008;
    public static int SC_FRIEND_CLOSEVALUE_CHANGE = 211009;
    public static int SC_BLACKNAME_LIST = 211010;
    public static int SC_HANDLE_APPLY_JOIN = 211011;
    public static int SC_CLEAR_APPLY_JOIN_LIST = 211012;
  }
}
