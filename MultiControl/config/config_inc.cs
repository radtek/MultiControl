﻿/* ======================================================================== 
 * 描述信息 
 *  
 * 作者：Ivan JL Zhang       
 * 时间：2016/11/2 15:12:50 
 * 文件名：config_inc 
 * 版本：V1.0.0 
 * 文件说明：
 * 定义相关配置信息与常量的类
 * 
 * 修改者：           
 * 时间：               
 * 修改说明： 
* ======================================================================== 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiControl.Common
{
    public class config_inc
    {
        /// <summary>
        /// tool版本号
        /// </summary>
        public const string MULTICONTROL_VERSION = "V1.6.7";
        /// <summary>
        /// Build日期
        /// </summary>
        public const string BUILD_DATE = "Build20161221";


        /// <summary>
        /// adb命令可重复执行最大次数
        /// </summary>
        public const int CMD_REPEAT_MAX_TIME = 10;

        public const int CMD_REPEAT_WAIT_TIME = 1000 * 1;

        /// <summary>
        /// 文件根目录
        /// </summary>
        public const string CFG_FILE_ROOT = "/Android/data/com.wistron.generic.pqaa/files/";
        /// <summary>
        /// PQAA config目录
        /// </summary>
        public const string CFG_FILE_PQAA = CFG_FILE_ROOT + "pqaa_config";

        public const string PATH_VERIFY_PATH = "path.verify.pass";

        public const string SPECIFIC_TAG_PATH = CFG_FILE_ROOT + PATH_VERIFY_PATH;



        public static readonly string[] mFileHeader = {
                                           "PQAA_Version", "SN", "Brand", "Model", "Android_Version",
                                           "IMEI1", "IMEI2", "Log_Time", "TestTime"
                                       };

        public static readonly string[] mFileTestItem = {
                                            "AudioLoopback","BlueTooth","Camera","ConfigChk","Display",
                                            "MoniPower","SDCard","TouchPanel","HeadsetLoopback","Vibration",
                                            "Wifi","RAM","OTG","GPS","NFC","SIM","Button","ReceiverLoopback",
                                            "LED","Audio","Brightness","ECompass","GSensor","GyroSensor",
                                            "LightSensor","ProximitySensor","Headset","MultiTouch","HallSensor",
                                            "HDMI","BarometerSensor","ReceiverLoopback","LTE","IrDA","WirelessCharging"
                                         };

        public static readonly string[] mFileFooter = {
                                           "Test_Result"
                                       };
    }

    public enum P_ID
    {
        NULL = 0, SAMSUNG = 26720
    }
    public enum V_ID
    {
        NULL = 0, SAMSUNG = 1256
    }
    public class DeviceManufactory
    {
        public P_ID p_id;
        public V_ID v_id;
        public string company_name = String.Empty;
    }
    public enum TEST_RESULT
    {
        PASS = 1, FAIL
    }
}
