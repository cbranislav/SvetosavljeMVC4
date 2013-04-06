﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Svetosavlje.Data_Layer.Interfaces;
using Svetosavlje.Data_Layer;
using System.Web;

namespace Svetosavlje.Services
{
    class DummyDataProvider : IDataProvider, IBlogProvider
    {

        public IList<MailListTopicInfo> GetTopicList(int rows)
        {
            IList<MailListTopicInfo> topicList = new List<MailListTopicInfo>(rows);

            for (int i = 1; i <= rows; i++ )
            {
                int msgId = i;
                string title = "Title " + i.ToString();
                int count = i;
                string user = "User " + i.ToString();
                DateTime updated = DateTime.Now;
                int updId = i;
                MailListTopicInfo ti = new MailListTopicInfo(msgId, title, count, user, updated, updId);
                topicList.Add(ti);
            }

            return topicList;        
        }



        public IList<PitanjeInfo> GetQuestionList(int rows)
        {

            IList<PitanjeInfo> questionList = new List<PitanjeInfo>(rows);

            for (int i = 1; i <= rows; i++)
            {
                questionList.Add(new PitanjeInfo(i, "Naslov " + i.ToString()));
            }

            return questionList;
        }



        public IList<string> GetList(int Mjesec, int Dan)
        {

            List<string> topicList = new List<string>();

            topicList.Add("Светац 1");
            topicList.Add("Светац 2");
            topicList.Add("Светац 3");
            topicList.Add("Светац 4");
            
            return topicList;
        }




        public string GetQuote(int Autor, int Mjesec, int Dan)
        {

            string quote = "Поука светих отаца за данашњи дан " + DateTime.Now.ToShortDateString();

            return quote;

        }


        public string GetFastingType(int Mjesec, int Dan)
        {
            return "Данас се пости на води";
        }



        public string GetZachala(int Mjesec, int Dan, int Godina)
        {
            string ctenije = "";

            ctenije += "На вечерњи:<br />" + "Вечерње читање";
            ctenije += "На јутрењу:<br />" + "Јутарње читање";
            ctenije += "На Св. Литургији, Еванђеље:<br />" + "Јеванђељско читање";
            ctenije += "На Св. Литургији, Апостол:<br />" + "Апостолско читање";

            return ctenije;
        }




        #region INews Members

        public IList<WPBlogModel> GetNews()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEditorNews Members

        public IList<WPBlogModel> GetEditorNews()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IMissionNews Members

        public IList<WPBlogModel> GetMissionNews()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
