﻿#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<MessageBoxOKCancelDlg>))]
    public class MessageBoxOKCancelDlg : GuiControl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onSleep()
            {
            this["callback"] = "";
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MessageBoxOKCancelDlg ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(MessageBoxOKCancelDlg ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(MessageBoxOKCancelDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxOKCancelDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MessageBoxOKCancelDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxOKCancelDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MessageBoxOKCancelDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxOKCancelDlg(int simobjectid)
            {
            return (MessageBoxOKCancelDlg) Omni.self.getSimObject((uint) simobjectid, typeof (MessageBoxOKCancelDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MessageBoxOKCancelDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageBoxOKCancelDlg(uint simobjectid)
            {
            return (MessageBoxOKCancelDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxOKCancelDlg));
            }

        #endregion
        }
    }