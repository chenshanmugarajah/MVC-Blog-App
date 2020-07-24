using NUnit.Framework;
using BlogApp;
using EFGetStarted;
using System.Linq;
using System;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    public class Tests
    {

        CRUDManager _crudManager = new CRUDManager();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadBlogs()
        {
            Blog blog = _crudManager.CreateBlog("testblog1");

            Blog blog2 = _crudManager.CreateBlog("testblog3");

            Assert.That(_crudManager.ReadBlogs(), Does.Contain(blog));


            //Assert.Contains(blog, _crudManager.ReadBlogs());

        }
    }
}