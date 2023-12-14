# How-to-set-badge-in-.NET-MAUI-TabView-header
This section illustrate How to set badge in .NET MAUI TabView header

#   Getting Started with .NET MAUI Tab View (SfTabView)

##  Adding a .NET MAUI Tab View reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Tab View to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.TabView and then install it.

## Create a simple .NET MAUI Tab View
This section explains how to create a .NET MAUI Tab View and configure it. The control can be configured entirely in C# code or by the XAML markup.

## Creating the project
Create a new .NET MAUI application in Visual Studio

## Adding a .NET MAUI Tab View control
*   Step 1: Add the NuGet to the project as discussed in the above reference section.

*   Step 2: Add the namespace as shown in the following code sample.

**XAML**

```
xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
```

*   Step 3: Set the control to content in ContentPage.

**XAML**
```
<ContentPage.Content> 
        <tabView:SfTabView /> 
</ContentPage.Content>  

```

#   Populate Tab Items in .NET MAUI Tab View
Tab items can be added to the control using the Items property of SfTabView.

**XAML**
```
 <ContentPage.Content> 
        <tabView:SfTabView x:Name="tabView">
            <tabView:SfTabView.Items>
                <tabView:SfTabItem Header="Call">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Red" />
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Favorites">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Green"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Contacts">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Blue"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>
            </tabView:SfTabView.Items>
        </tabView:SfTabView>
    </ContentPage.Content>  
</ContentPage>
```
#   To set badge in .NET MAUI TabView header

**XAML**
```
<ContentPage.Content>
    <tabView:SfTabView ItemsSource="{Binding TabItems}" TabWidthMode="Default"  >
        <tabView:SfTabView.HeaderItemTemplate>
            <DataTemplate>
                <Grid >
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="2*"/>
                        <ColumnDefinition Width="8*"/>
                    </Grid.ColumnDefinitions>
                    <core:SfBadgeView HorizontalOptions="Center"
                                      VerticalOptions="Center" 
                                      BadgeText="20" 
                                      Grid.Column="1" 
                                      Margin="0,30,0,0" >
                        <core:SfBadgeView.Content>
                            <Label Text="{Binding ID}" 
                                   WidthRequest="100"  
                                   HeightRequest="60" 
                                   Grid.Column="2" />
                        </core:SfBadgeView.Content>
                    </core:SfBadgeView>
                </Grid>
            </DataTemplate>
        </tabView:SfTabView.HeaderItemTemplate>
        <tabView:SfTabView.ContentItemTemplate>
            <DataTemplate>
                <Grid BackgroundColor="White" x:Name="AllContactsGrid" >
                    <ListView x:Name="ContactListView" 
                              ItemsSource="{Binding TabItems}"
                              RowHeight="75">
                        <ListView.BindingContext>
                            <local:TabItemsSourceViewModel />
                        </ListView.BindingContext>
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <StackLayout Orientation="Vertical" Margin="30,0,0,0">
                                        <Label Text="{Binding ID}"
                                       FontSize="24" />
                                    </StackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </DataTemplate>
        </tabView:SfTabView.ContentItemTemplate>
    </tabView:SfTabView>
</ContentPage.Content>
```