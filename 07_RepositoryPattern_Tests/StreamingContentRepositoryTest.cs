using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddToDirectory_ShouldBeCorrectBoolean()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDir_ShouldReturnRightCollection()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            List<StreamingContent> conts = repo.ReadContentFromDirectory();

            bool directorycontainsthings = conts.Contains(content);

            Assert.IsTrue(directorycontainsthings);
        }


        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("drama", "rubber", 1, StreamingQualityType.UHD4k, "dumb", "frog", ContentRatings.R);
            _repo.AddContentToDirectory(_content);
            
        }
        [TestMethod]
        public void getbytitle_shouldreturncorrectcontent()
        {
            StreamingContent searchresult = _repo.GetContentbyTitle("rubber");
            Assert.AreEqual(_content, searchresult);
        }
        [TestMethod]
        public void updateexstingcontentshouldbetrue()
        {
            StreamingContent newcontent = new StreamingContent("drama", "rubber", 100, StreamingQualityType.SD240, "dumb", "frog", ContentRatings.R);
            bool updateresults = _repo.UpdateyBoi("rubber", newcontent);
        }
        [TestMethod]
        public void deleteyboitestson()
        {
            bool deletionyboi = _repo.DeleteyBoi("rubber");
            Assert.IsTrue(deletionyboi);
        }

    }
}
