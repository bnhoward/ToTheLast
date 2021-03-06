using System;
using System.Collections.Generic;
using System.Text;
using Nightjar.ToTheLast.Entities;

namespace Nightjar.ToTheLast.DAL
{
    public interface IGigDAC
    {
        IList<IGig> Get(string where, string orderBy, int startIndex, int noRecords, out int totalNoRecords);
        IGig Get(int gigID);
        int Add(string description, string venue, DateTime startDateTime);
        bool Update(int gigID, string description, string venue, DateTime startDateTime);
        bool Delete(int gigID);
    }

    public interface IGuestbookDAC
    {
        IList<IGuestbook> Get(string where, string orderBy, int startIndex, int noRecords, out int totalNoRecords);
        IGuestbook Get(int guestbookID);
        int Add(string name, string email, string comment);
        //bool Update(int guestbookID, string name, string email, string comment, string reply, DateTime dateCreated);
        bool Update(int guestbookID,string reply);
        bool Update(int guestbookID,bool display);
        bool Delete(int guestbookID);
    }

    public interface INewsDAC
    {
        IList<INews> Get(string where, string orderBy, int startIndex, int noRecords, out int totalNoRecords);
        int Add(string subject,string newsText);
        bool Update(int newsID,string subject, string newsText);
        bool Delete(int newsID);
    }

    public interface IImageDAC
    {
        IList<IImage> Get(int galleryID);
        IImage GetImage(int imageID);
        void Add(string filename, string title, int galleryID,int sortOrder);
        bool Update(int imageID,  string title, int sortOrder);
        bool Delete(int imageID);
    }

    public interface IGalleryDAC
    {
        IList<IGallery> Get();
        IGallery GetGallery(int galleryID);
        void Add(string name, string description,int sortOrder);
        bool Update(int galleryID, string name, string description, int sortOrder, string displayImage);
        bool Delete(int galleryID);
    }

    public interface ILinkDAC
    {
        IList<ILink> Get(string where, string orderBy, int startIndex, int noRecords, out int totalNoRecords);
        ILink Get(int linkID);
        int Add(string url,string title,string note,int sortOrder);
        bool Update(int linkID, string url, string title, string note, int sortOrder);
        bool Delete(int linkID);
    }

    public interface IProfileDAC
    {
        IList<IProfile> GetAll();
        IProfile GetProfile(int profileID);
        int Add(string name, string profileText,int sortOrder);
        bool Update(int profileID,string name, string profileText, int sortOrder);
        bool Delete(int profileID);
    }
}
