   M S B A M L   `   `   `  ????U  QFlowerShopManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FlowerShopManagementSystemFlowerShopManagementSystem  5      8    2FlowerShopManagementSystem.Suppliers.SuppliersView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FlowerShopManagementSystem     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        ? 	Resources  5         	BoolToVis ?? 
TargetType ?? 
ResourceId ?? TypeInTargetAssembly&   System.Windows.Controls.DataGrid ?? Property ?? Value ?? 
TargetType ??Name J? SnapsToDevicePixels	 ?Name
 J? Opacity ? Points ?? Stretch ?? Triggers P? Property P? Value ?? 
TargetName??%?  &	        (??      5      $" DataGridSelectAllButtonStyle??"  )?? 5   
   6'   ?? 5   
   " ??6   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ? .+?5      ?? $ Border??6(   #??? ??68    . 6y   ? 5      $	 Arrow??6&   
???   ?$??Right=?6B   $??8,8,3,3q?6^   $

 0.15Q?6o    ?   ??? ??? ??? ??? $ Uniform=?6?   $??Bottom=?6?   5       5      P? 5       ?@J?IsMouseOver . . ?5   "   ?? $ Border??6;   # ? ??6O    ? ??5      P? 5       ? ?? . . ?5   "   ?? $ Border??69   # ? ??6M    ? ??5      P? 5       ? {? .  . ?5   "   ?? $ Arrow??6?    ? y?$ 	Collapsed=?6R   5      5!      5#      5$      5%      .??5'      ? ???#EFF2F7 ? RowDefinitions 5(   
   ?? 5)      $
??auto ?6   ?? 5*      $
??auto ?6   ?? 5+      $
??auto ?6   ?? 5,      $??* ?6   ?? 5-      $
??auto ?6   .+?50   
   ?? $??	Suppliers??6   $??32(?6%   $??SemiBold"?63   $??0 20 0 0q?6I   ???#121518$
??Left=?6p   ?? 52   
   -   5         ??Name$ btnAddNewSupplier??52   A     	addButton#??[ 6   $??0??64    ? Cursor$
 Hand??6\   .??53      ??  ?? Orientation$ 
Horizontal=?6   .+?54      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?6(   $??Center=?64   $??0 1 8 0q?6O   $??11??6`   $??11??6k   ?? 55      $??Add new supplier??6   56      58      ?? 5:   
   $??1??6   $??1??6   ???#DAE2EA$??	0 -1 0 10q?6A   ?? 5<   
   $??10 Suppliers??6   $??2??6(   $??18(?65   $??SemiBold"?6C   ???#121518$
??Left=?6n   $??Center=?6?   ?? 5>   
   $??	Filter by??6   $??2??6%   $??13(?62   $??SemiBold"?6@   $??	0 0 215 0q?6V   ???#121518$??Right=?6~   $??Center=?6?   ? 5@   
   $	??200??6   $??Right=?6   $??2??67   .+?5A      ?? $
??10 0q?6   $??Center=?6&   ???#B0B9C6 J? IsHitTestVisible .   K? ZIndex$ 1??5B      $??Search in Suppliers ...??6-   y?5C      ??  ?? ElementName$ textBoxFilter?? ?? Path$ Text.IsEmpty? ?? 	Converter# [  ?? 5E      -   5        $??textBoxFilter??5E        filterTextBox#??[ 6+   5F        5H   
   -   5          Name$ suppliersDataGrid??5H   ?     DataGridStyle1#???  6     DataGridCellStyle1   	CellStyle# ?  6<     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6m   $??3??6?      RowStyle 5I      ?? 5J      )  #System.Windows.Controls.DataGridRow"  6   .?5K      -   5        ?? 5L       ? ??$ 0 4 0 0q?6/   ?? 5M       ? ?? ?#FFFFFF63   ?? 5N       ?@J?SnapsToDevicePixels . 6<   ?? 5O       ?@=?ErrorTemplate 6A   Z? ?? 5P       ?@?Cursor$
 Hand??6/   ?? 5Q       ?@ ValidationErrorTemplate 5R      ?? 5S      .R?5T   "   ?? 
???  ??$??2,0,0,0q?6=   $??!??6N   $??Center=?6W   5U      5W      ?? 5X       ? ?? 5Y      ?? 5Z      "  6.   .R?5[   "   ??  ??Name$ 
DGR_Border??6)     ?? Padding$	  0 8q?6=   ! ?? CornerRadius$! 5??6K   #??z??6\   $??0q?6?    . ._?5\   &   ?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid  " ? ColumnDefinitions" 5]   *   ?? 5^   .   $
??Auto ?6?   ?? 5_   .   $??* ?6?    5a   *   ?? 5b   .   $??* ?6<   ?? 5c   .   $
??Auto ?6<   .+?5e   *   ?  9System.Windows.Controls.Primitives.DataGridCellsPresenter  $??1??6A   #   
ItemsPanel#??z# 6Q   # z 6{   A  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter  5f   *   $??1??6C   $??1??6S   $   DetailsVisibility#y?z$ 6w  $%   SelectiveScrollingOrientation% 6`   ?? *AreRowDetailsFrozen+#&   RowDetailsScrollingConverter# Z& ;  5System.Windows.Controls.SelectiveScrollingOrientation'   Vertical( ?? ConverterParameter#( Z' ) ?? RelativeSource) ?? * ?? AncestorType"*  6w  :  4System.Windows.Controls.Primitives.DataGridRowHeader  5g   *   $??2??6<   $% Vertical=?6M   y?6?   ?? *HeadersVisibility+!+   HeadersVisibilityConverter# Z+ 7	  1System.Windows.Controls.DataGridHeadersVisibility
, 	  Row#( Z, ) ?? "*  5h   '   5i   #   5j      5l      - ?? Triggers- 5n      P? 5o       ?@J?IsMouseOver . . ?5p      ??  ? ?? ?#e5e5e56;   5r      P? 5s       ?@ 
IsSelected . . ?5t      ??  ? ?? ?#e5e5e56;   5v      ]? 5w      . ]? 
Conditions. 5x      ?? 5y   "   / ?? Property/ ?@ 
IsSelected0 ?? Value0 . 6B   ?? 5z   "   / ?@??IsSelectionActive0 .  6R   ./?5|      ??  ? ?? ?#dfdfdf6;   5}      5      1   Columns1 5?      0
  *System.Windows.Controls.DataGridTextColumn
  5?      ,  &System.Windows.Controls.DataGridColumn2   Header$2 #??6%   3   
IsReadOnly3 . 4   CanUserResize4 .  5   Width5  /System.Windows.Controls.DataGridLengthConverter$
5 auto 6X   1  +System.Windows.Controls.DataGridBoundColumn6   Binding6 6e   ?? *sttNCC+4  .System.Windows.Controls.DataGridTemplateColumn  5?      $2 Supplier Name??6)   3 . $5 * 6R   7   CellTemplate7 5?      ?? 5?      .R?5?      ?? $ 
Horizontal=?6)   .+?5?   "   ?? $??Center=?6D   ??6,   ?? *tenNCC+6D   5?      5?      5?      
  5?      $2 Address??6%   3 . $5 * 6H   6 6R   ?? *	diaChiNCC+
  5?      $2 Phone Number??6%   3 . $5 * 6M   6 6W   ?? *	soDTNCC+  5?      $2 
Operations??6)   3 . $
5 auto 6O   7 5?      ?? 5?      .R?5?      ?? $ 
Horizontal=?6)   .+?5?   "   ?? $ btnEditSupplier??6)   -   5          gridEditButton#??[ 5?   B   $
 Hand??6j   .??5?   &     $ PencilOutline=?6<     gridButtonIcon#??[ 6Q   5?   #   ?? 5?   "   $ btnDeleteSupplier??6)   -   5          gridRemoveButton#??[ 5?   D   $??5 0 0 0q?6n   $
 Hand??6   .??5?   &     $ DeleteOutline=?6<   #??[ 6Q   5?   #   5?      5?      5?      5?      ?? 5?   
   $??4??6   $??Right=?6   ???#dee4ec$??1q?6P   $! 5??5?      $  5q?6"   
???????$??
0 10 10 10q?6A   ._?5?      ?? $ 
Horizontal=?6   .+?5?      ?? -   5        $ btnFirstPage??5?   ?    	 pagingButton#??[	 6   .??5?        $ ChevronDoubleLeft=?6,    
 pagingButtonIcon#??[
 6E   5?      ?? 5?      -   5        $ btnPreviousPage??5?   ?   #??[	 6   .??5?        $ ChevronLeft=?6,   #??[
 6?   5?      ?? 5?      $??1??6   ???#dee4ec$	??3 7q?65   ?? 5?        pagingTextBlock#??[ 69   ??6   ?? *CurrentPage+69   ?? 5?      $??of??6   #??[ 6&   $??0q?6O   ?? 5?      #??[ 67   ??6   ?? *	PageCount+67   ?? 5?      $??1??6   ???#dee4ec$	??3 7q?65   ?? 5?      -	   5        $ btnNextPage??5?   ?   #??[	 6   .??5?        $ ChevronRight=?6,   #??[
 6@   5?      ?? 5?      -
   5        $ btnLastPage??5?   ?   #??[	 6   .??5?        $ ChevronDoubleRight=?6,   #??[
 6F   5?      5?      5?      5?      5?      