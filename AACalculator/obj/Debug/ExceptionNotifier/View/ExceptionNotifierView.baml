   M S B A M L   `   `   `  ����  AACalculator?    9AACalculator.ExceptionNotifier.View.ExceptionNotifierView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Exception Notifier��5   	   $	��200��6$   $	��500��61    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5	       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   $��0��6    5      �� 5       5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��0��6   $��0��6$   ��61   ��  �� Path$ TitleMessage�� 5      $��0��6   $��1��6#    5      �� 5      $	��128 �6'   �� 5      $��* �6'   .+�5      �� -   5        $��
imgMsgType��5      $	��128��6*   $
��Auto��66   ��6D   �� $ ImageFilePath� � Triggers 5      :� 5"       :� RoutedEvent$ Image.Loaded��6'   .[�5#      �� .��5$   "   �� .��5%   &   W�  �� 
TargetName$ 
imgMsgType��5&   +    �� TargetProperty$ Opacity�5'   +   	 W� From$		 1.0X�5(   +   	
 W� To$

 0.25X�66    g� Duration$ 0:0:3D�6@    g� AutoReverse .  g� RepeatBehavior$ Forever��6d   5)   #   5*      5+      5.      �� 5/      $��1��6   $
��Auto=�6/   .��50      �� $��1��6    {�.  ��60   �� *ExceptionMsg+ �� Mode$ OneWay=�6[   51      52      53      �� 54   
   $
��Auto��6    �� Orientation$ 
Horizontal=�6#   $��Right=�6<   $��1��6X   $��0��6e   .+�55      �� ��6   �� *CopyCommand+.��65   Copy to Clipboard6H   �� 56      -   5         ��Name$ btnClose��56       �� IsCancel . ��6'   �� *CloseCommand+.��6X   Close6_   57      58      59      