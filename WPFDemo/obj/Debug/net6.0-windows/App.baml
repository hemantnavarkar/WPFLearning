   M S B A M L   `   `   `  ����B  >WPFDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFDemoWPFDemo  5      A%clr-namespace:WPFDemo.ValueConvertersWPFDemo.ValueConverters  5          WPFDemo.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:WPFDemo     5      <
converters%clr-namespace:WPFDemo.ValueConverters     5        �� 	Resources  5         progressPie �� 
TargetType � 	Resources9  3WPFDemo.ValueConverters.ValueMinMaxToPointConverter  Key>   8WPFDemo.ValueConverters.ValueMinMaxToIsLargeArcConverter A�Name F�Name E� 
StartPoint E� IsClosed �� Point �� Size	 �� SweepDirection
 �� Point  
converter1 `� 	Converter �� Path �� RelativeSource �� Mode �� 
IsLargeArc  
converter2 �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value �� 
StartPoint �� EndPoint � Offset � Color��%�  &	        7  7  �� 5   
   " �6.    5	      ��  5
      
converter1 6=     5      
converter2 6B   5      .R�5      (� .��5      � $��20��6   $��20��6"   .+�5      A� $ innerbackground��6   #��z��5      #��z��5      $��20��5      $��20��5      #��z��5      F� 5      $	 pie��6   #��z��6(   ��5      B� 5      .��5   "   E� $ 10,10&�6-   $
 True��5   -   .��5   &   �� $
 10,0&�62   �� 5   &   $ 10,10��61   $	 	Clockwise=�6>   
 5   *   `� 5    .   8   .1�5!   2   �� $ Value�6q    6:   �� $ TemplatedParent=�6q   �� 5"   2   $ Minimum�6q    6:   �� $ TemplatedParent=�6q   �� 5#   2   $ Maximum�6q    6:   �� $ TemplatedParent=�6q   5$   /    5&   *   `� 5'   .   8  .1�5(   2   �� $ Value�6q    6:   �� $ TemplatedParent=�6q   �� 5)   2   $ Minimum�6q    6:   �� $ TemplatedParent=�6q   �� 5*   2   $ Maximum�6q    6:   �� $ TemplatedParent=�6q   5+   /   5-   '   5.   #   5/      51      52      53       55      P� 56       �@�IsIndeterminate$
 True��65   . �57      �� $	 pie��6    � y�$ Hidden=�6D   �� 58      $ innerbackground��6    � �� 59      �� 5:      $	 0,0&�62   $	 1,1&�6C   .��5;   "   � $ 0Q�6/   $ Yellow��6:   � 5<   "   $ 1Q�6/   $ Brown��6:   5=      5?      �� 5@       � {�$ False��62   �� 5A      $	 pie��6    � �� 5B      �� 5C      $	 0,0&�62   $	 1,1&�6C   .��5D   "   � $ 0Q�6/   $
 Gray��6:   � 5E   "   $ 1Q�6/   $ White��6:   5F      5H      5I      5K      5L      5M      