using Livet;
using Livet.Commands;
using NodeGraph.NET6.Operation;
using NodeGraph.NET6.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NodeGraph.NET6.Controls;
using System.Windows.Controls;

namespace NodeGraph.NET6.ViewModels
{

  public enum GroupIntersectType
  {
    CursorPointVMDefine,
    BoundingBoxVMDefine,
  }

  public enum RangeSelectionMode
  {
    ContainVMDefine,
    IntersectVMDefine,
  }

  public class MainWindowViewModel : ViewModel
  {
  }
}
