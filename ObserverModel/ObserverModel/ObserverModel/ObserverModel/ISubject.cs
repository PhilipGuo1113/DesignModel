using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverModel
{
    interface ISubject
    {
        /// <summary>
        /// 传播内容
        /// </summary>
        object BroadObject { get; set; }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="o"></param>
        void Attach(CObject o);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="o"></param>
        void Dettach(CObject o);
        /// <summary>
        /// 通知
        /// </summary>
        void Notify();
    }
}
