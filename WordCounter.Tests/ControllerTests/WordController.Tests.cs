using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        WordsController controller = new WordsController();
        ActionResult indexView = controller.Game();
        Assert.IsInstanceOfType (indexView, typeof (ViewResult));
      }


   //    [TestMethod]
   //    public void Index_HasCorrectModelType_ItemList()
   //    {
   //      //Arrange
   //      ItemsController controller = new ItemsController();
   //      ViewResult indexView = controller.Index() as ViewResult;
   //
   //      //Act
   //      var result = indexView.ViewData.Model;
   //
   //      //Assert
   //      Assert.IsInstanceOfType(result, typeof(List<Item>));
   //  }
   //
   //  [TestMethod]
   // public void Create_ReturnsCorrectActionType_RedirectToActionResult()
   // {
   //     //Arrange
   //     ItemsController controller = new ItemsController();
   //
   //     //Act
   //     IActionResult view = controller.Create("Walk the dog");
   //
   //     //Assert
   //     Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
   // }
   //
   //   [TestMethod]
   //   public void Create_RedirectsToCorrectAction_Index()
   //   {
   //       //Arrange
   //       ItemsController controller = new ItemsController();
   //       RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;
   //
   //       //Act
   //       string result = actionResult.ActionName;
   //
   //       //Assert
   //       Assert.AreEqual(result, "Index");
   //   }
   //


    }
}
