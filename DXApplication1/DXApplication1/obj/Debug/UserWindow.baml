   M S B A M L   `   `   `  ����I  EDXApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DXApplication1DXApplication1  5   	       DXApplication1.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DXApplication1     5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   f bDevExpress.Xpf.Accordion.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aKdxai@http://schemas.devexpress.com/winfx/2008/xaml/accordion/internal  5   	   f bDevExpress.Xpf.Grid.v22.2.Core, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5	   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ 
UnitWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   � $��0��6   .+�5      � $��0 0 0 10q�6   .+�5      �� $	��130��6   $��25��6&   $��5 5 15 5q�6L   ��62   �� *
Username+6L   �� 5      $	��130��6   $��25��6'   $��5 5 15 5q�6P    �� 
IsEditable . ��63   �� *Role+ �� SelectedItem 6b   �� *SelectedRole+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $	��130��6   $��25��6&   $��5 5 15 5q�6t   ��62   �� *DisplayName+$ PropertyChanged=�6t   5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5       �� 5!      .+�5#      � $��0��6   .+�5$      �� $��Thêm��68   $��5q�6G   $	��100��6R   ��6   �� *
AddCommand+6R   5%      � 5&      $��1��6   .+�5'      �� $��Sửa��68   $��5q�6F   $	��100��6Q   ��6   �� *
AddCommand+6Q   5(      � 5)      $��2��6   .+�5*      �� $
��Xóa��68   $��5q�6F   $	��100��6Q   ��6   �� *
AddCommand+6Q   5+      5,      � 5-   
   $��2��6   .+�5:      %  DevExpress.Xpf.Grid.GridControl  -   5        	  Name$
	 grid��5:      )  #DevExpress.Xpf.Grid.DataControlBase
   AutoGenerateColumns$
 AddNew=�6,   #   EnableSmartColumnsGeneration .    RestoreStateKeyFieldName$ Id��6m   !   RestoreStateOnSourceChange .    TotalSummary 5;      )  #DevExpress.Xpf.Grid.GridSummaryItem  5<      )  #DevExpress.Xpf.Grid.SummaryItemBase   	Alignment$ Right=�6*      SummaryType]	 YDevExpress.Data.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a5 	 /DevExpress.Data.Design.SummaryItemTypeConverter$ Count 6<    J� InputBindings 5>      �� 5?      
 �� Key$ Delete��6f    �� Command 6!   �� * View.Commands.DeleteFocusedRow+ �� ElementName$
 grid��6f      View 5A      #  DevExpress.Xpf.Grid.TableView  5B      -   5           NewItemRowPosition$	 Top=�5B   $      ShowUpdateRowButtons$ OnCellEditorOpen=�6=   &   DevExpress.Xpf.Grid.DataViewBase   ShowFixedTotalSummary . 6�      Columns. 5D      $  DevExpress.Xpf.Grid.GridColumn  $	  DevExpress.Xpf.Grid.ColumnBase 	  	FieldName$ Id��6!    	  IsSmart .  	  ReadOnly . 6?     5E      $ DisplayName��6!    . 69     5F      $ UserName��6!    . 66     5G      $ Password��6!    . 66     5H      $ IdRole��6!    . 64   5I      5J      @
  :DevExpress.Xpf.Accordion.Native.AccordionVirtualizingPanel
  5K   
   5L      5M      