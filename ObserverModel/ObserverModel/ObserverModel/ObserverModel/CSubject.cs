using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverModel
{
    class CSubject : ISubject
    {
        /// <summary>
        /// 传播内容
        /// </summary>
        private object _broadObject;
        public object BroadObject
        {
            get { return _broadObject; }
            set
            {
                if (null != value)
                {
                    _broadObject = value;
                }
            }
        }
        /// <summary>
        /// 注册队列
        /// </summary>
        private List<CObject> ObjectList = new List<CObject>();
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="o"></param>
        public void Attach(CObject o)
        {
            if (!ObjectList.Contains(o))
            {
                ObjectList.Add(o);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="o"></param>
        public void Dettach(CObject o)
        {
            if (ObjectList.Contains(o))
            {
                ObjectList.Remove(o);
            }
        }
        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (CObject o in ObjectList)
            {
                o.Update(BroadObject);
            }
        }
    }
}
