   M S B A M L   `   `   `  ����I  EbindingExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:bindingExample.ViewbindingExample.View  5      '    !bindingExample.View.ButtonControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:bindingExample.View     5      
������ .��5	      � .+�5
   
   �� .+�5      �   � RowDefinitions  5      �� 5      6&   �� 5      6&   .+�5      �� $��60��6   $��60��6'   
���   �6B   �� 5      $��50��6   $��50��6'   
�������6B   �� 5      
���   �$��20(�6C   $��Center=�6R   $��Center=�6o   ��6   �� *Id+6�   �� 5      $��1��6   $	��200��6'   $	��200��63   ���	#FFBD3838��6@   �� *Name+��5      ��  �� Path$! DataContext.DepartmentClick� �� ElementName$ Parent����6f   �� ��5      �� 5       �� 
TargetType" ��6*   .R�5      �  �Name$ RootGrid��6#    J� RenderTransformOrigin$ 0.5,0.5&�65   .+�5   "   A� 
���   �$	��200��67   $	��200��6D   A� 5   "   
����ح�$	��190��6;   $	��190��6H   �� 5   "   #��z��63   $��Center=�6W   $��Center=�6t   5       �� Triggers 5       P� 5!   "    P� Property � �� P� Value . . �5"   &   �� 	 �� 
TargetName$	 RootGrid��6-   
 �� Property
 � z� �� Value 5#   *   �� 5$   .    �� ScaleX$	 0.9Q�6=    �� ScaleY$	 0.9Q�6J   5&   '   5'   #   5)      5+      5-      5/      50      51      