   M S B A M L   `   `   `  ����A  =Wallet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WalletWallet  5   	       Wallet.MainWallet   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Wallet     5   	     � Title$  Wallet��5   	   
����ح�$	��330��6/   $	��700��6<    � 
ResizeMode$ NoResize=�6H   .��5	      � .+�5
   
   �� -   5        $��address��5
      $
��Left=�6"   $��	20,20,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��500��6�   $	��700��6�   $��30��6�   6�   �� 5   
   -   5        
�������$��50��5   9   $
��Send��6D   $��	0,20,20,0q�6S   $��Right=�6f   $��30��6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.467,1.049&�6�   �� 5   
   -   5        
�������$	��120��5   @   $��Import PrivKey��6L   $��
554,55,0,0q�6e   $
��left=�6y   $��30��6�   $	��Top=�6�   $ 0.467,1.049&�6�   �� 5   
   -   5         ��Name$ 
OrdersView��5   r   $
��Left=�6   $	��180��6.   $��	20,95,0,0q�6;   $	��Top=�6N   $	��654��6f   
���������6�   ��  �� Path$ 	OrderList���5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � |� �� Value .  62   5      	 �� View	 5      �� 5      .P�5      �� $��Amount��6%   
 �� Width$	
 100��6]    �� DisplayMemberBinding 65   �� *AMOUNT+6]   �� 5      $��TransactionID��6%   $	
 300��6k    6<   �� *TRANSACTIONID+6k   �� 5      $��BlockID��6%   $	
 252��6_    66   �� *	BLOCKID+6_   5      5      5      5      