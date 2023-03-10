
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BattleInArea.Game
{
    public partial class Page
    {


        /// <summary>
        /// Battle In Area UI Manager
        /// </summary>
        public class Title : Core.Page.IPage
        {

            public int ID
            {
                get { return (int)Page.ID.Title; }
            }


            public IEnumerator OnPreEnter()
            {
                yield return Core.Coroutine.instance.StartCoroutine(Helper.DataBase.LoadTables());
            }

            public void OnEnter()
            {
                Event.PageModify evt = Core.Event.Getter.Get<Event.PageModify>();
                evt.hashtable["page"] = Page.ID.Title;
                evt.hashtable["state"] = Event.PageState.OnEnter;
                Core.Event.Dispatcher.Dispatch(evt);

            }

            public void OnExecute()
            {

            }

            public void OnExit()
            {
                Event.PageModify evt = Core.Event.Getter.Get<Event.PageModify>();
                evt.hashtable["page"] = Page.ID.Title;
                evt.hashtable["state"] = Event.PageState.OnExit;
                Core.Event.Dispatcher.Dispatch(evt);
            }
        }
    }
}