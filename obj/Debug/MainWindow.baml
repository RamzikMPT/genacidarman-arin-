   M S B A M L   `   `   `  ����B  >PC_klub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PC_klubPC_klub  5   	       PC_klub.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PC_klub     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      � ���	#FFDC9C9C � ColumnDefinitions 5   
   �� 5      $
��767* �6   �� 5      $	��33* �6   .+�5   
   �� -   5        $��Button��5      $
��Left=�6"   $��	0,390,0,0q�6=   $	��Top=�6P   $	��800��6h   $��2��6t   $��44��6�   �� 5   
   $��51��6   $	��Top=�6!   $��	0,334,0,0q�69   .+�5      G� -   5         G�Name$ PASSWORD��5       %  !MaterialDesignOutlinedPasswordBox#��[  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Password��5      5      �� 5   
   $��46��6   $	��Top=�6!   $��	0,269,0,0q�69   .+�5      �� -   5         ��Name$ LOGIN��5        MaterialDesignFilledTextBox#��[ 5       �� TextWrapping$
 Wrap=�5       �� 	MaxLength$ 40��5      $ LOGIN��5      $	��769��6,   $��44��68   .  (MaterialDesignThemes.Wpf.TextFieldAssist!   CharacterCounterVisibility 5      �� *	IsChecked+   BooleanToVisibilityConverter �� 	Converter# [ 	 �� ElementName$2	 ,MaterialDesignFilledTextBoxTextCountComboBox��5   8   5      �� 5   
   $��Center=�6   $��	0,132,0,0q�61   $
��Wrap=�6D   $ ��Авторизуйтесь��6X   $	��Top=�6m   $
��Bold"�6�   $��20(�6�   5!      5"      