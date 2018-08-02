﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automaticu.HydraulicFormulas.UnitTest
{
   [TestClass]
   public class UnitTestColebrookWhite
   {
      [TestMethod]
      public void TestColebrookWhite()
      {
         double epsilon_relative_roughness = 0.15;
         double DH_hydraulic_diameter = 136;
         double Re_reynolds_number = 1.87e+6;

         double colebrook_white_bisection = HydraulicFormulas.CollebrookWhiteBisection(epsilon_relative_roughness, DH_hydraulic_diameter, Re_reynolds_number);
         double colebrook_white_brent = HydraulicFormulas.CollebrookWhiteBrent(epsilon_relative_roughness, DH_hydraulic_diameter, Re_reynolds_number);

         Assert.AreEqual(0.020267, Math.Round(colebrook_white_bisection,6));
         Assert.AreEqual(0.020267, Math.Round(colebrook_white_brent,6));
      }
   }
}
