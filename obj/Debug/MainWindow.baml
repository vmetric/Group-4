   M S B A M L   `   `   `  ����O  KGroup 4 Project Num2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Group_4_Project_Num2Group_4_Project_Num2  5   	   %    Group_4_Project_Num2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Group_4_Project_Num2     5   	     � Title$  
MainWindow��5   	   $	��165��6   $	��340��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ articleComboBox��5
      $
��Left=�6,   $��
189,13,0,0q�6G   $	��Top=�6[   $	��120��6s   .@�5      �� $��Long-sleeve shirt��6   �� 5      $��T-shirt��6   5      �� 5   
   -   5        $ materialComboBox��5      $
��Left=�6-   $��
189,44,0,0q�6H   $	��Top=�6\   $	��120��6t   .@�5      �� $��Cotton��6   �� 5      $
��Wool��6   �� 5      $��Spandex��6   �� 5      $��	Polyester��6   �� 5      $��Nomex��6   �� 5      $	��Mix��6   5      �� 5   
   -   5         ��Name$  textBox_MaterialOnePercent��5      $
��Left=�66   $��23��6Q   $��
513,84,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5        $  textBox_MaterialTwoPercent��5      $
��Left=�66   $��23��6Q   $��513,112,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5   
   $'��!What is your article of clothing?��6   $
��Left=�6<   $��	10,10,0,0q�6W   $	��Top=�6j   �� 5   
   $��What is it made of?��6   $
��Left=�6.   $��	10,41,0,0q�6I   $	��Top=�6\   �� 5   
   -   5         ��Name$ label_FirstMaterial��5      $!��What is the first material?��6-   $
��Left=�6S   $��
345,18,0,0q�6n   $	��Top=�6�   $y�Hidden=�6�   �� 5   
   -   5        $ label_SecondMaterial��5      $"��What is the second material?��6.   $
��Left=�6U   $��
345,46,0,0q�6p   $	��Top=�6�   $y�Hidden=�6�   �� 5   
   -   5        $ comboBox_FirstMaterial��5      $
��Left=�63   $��
513,21,0,0q�6N   $	��Top=�6b   $	��120��6z   $y�Hidden=�6�   .@�5      �� $
��Wool��6   �� 5      $��Cotton��6   �� 5      $��Spandex��6   �� 5       $��	Polyester��6   �� 5!      $��Nomex��6   5"      �� 5#   
   -   5        $ comboBox_SecondMaterial��5#      $
��Left=�64   $��
513,49,0,0q�6O   $	��Top=�6c   $	��120��6{   $y�Hidden=�6�   .@�5$      �� $
��Wool��6   �� 5%      $��Cotton��6   �� 5&      $��Spandex��6   �� 5'      $��	Polyester��6   �� 5(      $��Nomex��6   5)      �� 5*   
   -	   5        $ label_MaterialOnePercent��5*      $0��*What is the percent of the first material?��62   $
��Left=�6g   $��
268,84,0,0q�6�   $	��Top=�6�   $y�Hidden=�6�   �� 5+   
   -
   5        $ label_MaterialTwoPercent��5+      $1��+What is the percent of the second material?��62   $
��Left=�6h   $��268,110,0,0q�6�   $	��Top=�6�   $y�Hidden=�6�   �� 5,   
   -   5         ��Name$ button_Predict��5,      $��Predict��6)   $
��Left=�6;   $��	10,70,0,0q�6V   $	��Top=�6i   $��75��6�   6�   �� 5-   
   -   5        $��View Experimental Data��5-      $
��Left=�62   $��	10,94,0,0q�6M   $	��Top=�6`   6x   5/      50      