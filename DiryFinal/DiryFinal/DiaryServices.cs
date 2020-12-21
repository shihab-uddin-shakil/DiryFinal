using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiryFinal
{
    class DiaryServices
    {
        DataAccesscs dataAccess;
        DiryAccess diaryAccess;
        Diry diary = new Diry();
        public DiaryServices()
        {
            this.diaryAccess = new DiryAccess();
            this.dataAccess = new DataAccesscs();
        }

        public List<Diry> GetEventtList()
        {

            return diaryAccess.GetEvent();
        }

        public int AddNewEvent(string Experience, string Thought, string Fellings, string Importance,byte[] Picture, string EventDate)
        {
            Diry diary = new Diry();
            diary.Experience = Experience;
            diary.Thought = Thought;
            diary.Fellings = Fellings;
            diary.Importance = Importance;
            diary.Picture = Picture;
            diary.EventDate = EventDate;

            DiryAccess diaryAccess = new DiryAccess();

            return this.diaryAccess.InsertEvent(diary);

        }
        public int UpdateOldEvent(string Experience, string Thought, string Fellings, string Importance, byte[] Picture, string EventDate,int id)
        {
            Diry diary = new Diry();
            diary.Experience = Experience;
            diary.Thought = Thought;
            diary.Fellings = Fellings;
            diary.Importance = Importance;
            diary.Picture = Picture;
            diary.EventDate = EventDate;
            diary.Number = id;

            DiryAccess diaryAccess = new DiryAccess();

            return this.diaryAccess.InsertEvent(diary);

        }
    }

}
