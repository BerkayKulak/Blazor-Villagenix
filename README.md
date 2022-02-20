


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

<img width="100%" src="https://user-images.githubusercontent.com/61355143/154837016-a7c60eb8-2faa-4de9-984e-f66ec14f5ce7.png">
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154835967-c598eb19-5189-4a7e-92bd-2052383d9ae9.gif">
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154835677-d3a1204c-4a72-46f6-b2a2-ef383a9cc7de.gif">



Here's why:
Blazor is an exciting new part of .NET Core (.NET 5) designed for building rich web user interfaces in C#. This course will help developers transition from building basic sample apps to implementing more real world concepts, design patterns, and features.

* You should implement DRY principles to the rest of your life :smile:

For years JavaScript frameworks have dominated the front end/client side development! But things are about to change with Blazor!

- How do you scale an existing application? 
- How do you architect a mid-large scale project?
- How to correctly process payments?
- Add changes to reflect the changes made
- How to efficiently understand Blazor and use it in real world projects?

help developers transition from building basic sample apps to implementing more real world concepts, design patterns, and features.



### Built With

This section should list any major frameworks/libraries used to bootstrap your project. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.

* [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
* [Asp.Net Core API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)
* [MSSql](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-6.0)

### Technologies and Methods

- Real world application using Blazor Web Assembly
- Manage admin features using Blazor Server
- Build .NET 5 API from scratch
- Consume .NET 5 API using Blazor WASM
- Authentication & Authorization in Blazor Server and WASM
- Integrate Stripe Payments in Blazor WASM
- Repository Pattern and Dependency Injection
- Deploying .NET API, Blazor WASM & Server to Azure

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* dotnet Villagenix.API.csproj
  ```sh
  <PackageReference Include="AutoMapper" Version="10.1.1" />
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
  <PackageReference Include="Mailjet.Api" Version="1.2.3" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.2" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="5.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
  ```
  
* dotnet Villagenix.Client.csproj
  ```sh
  <PackageReference Include="Blazored.LocalStorage" Version="3.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.Authorization" Version="5.0.14" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="5.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="5.0.0" />
  <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
  <PackageReference Include="System.Net.Http.Json" Version="5.0.0" />
  ```
  
* dotnet Villagenix.Server.csproj
  ```sh
   <PackageReference Include="AutoMapper" Version="10.1.1" />
   <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
   <PackageReference Include="Blazored.TextEditor" Version="1.0.3" />
   <PackageReference Include="Microsoft.AspNetCore.Identity" Version="2.2.0" />
   <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.2" />
   <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="6.0.2" />
   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2" />
  ```


### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._


1. Clone the repo
   ```sh
   https://github.com/BerkayKulak/Blazor-Villagenix.git
   ```
2. Update Nuget packages
   ```sh
   dotnet tool update <PACKAGE_ID> -g|--global
   ```
3. Add Migration
   ```js
   dotnet ef migrations add InitialCreate
   ```
4. Update Database
   ```js
   dotnet ef database update
   ```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

To clone and run this application, you'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer. From your command line:

```bash
# Go into the repository API
$ cd \Villagenix\Villagenix.API

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Server
$ cd \Villagenix\Villagenix.Server

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Client
$ cd \Villagenix\Villagenix.Client

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj
```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [x] Add Changelog
- [x] Add back to top links
- [ ] Add Additional Templates w/ Examples
- [ ] Add "components" document to easily copy & paste sections of the readme
- [ ] Multi-language Support
    - [ ] Chinese
    - [ ] Spanish

See the [open issues](https://github.com/othneildrew/Best-README-Template/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@your_twitter](https://twitter.com/your_username) - email@example.com

Project Link: [https://github.com/your_username/repo_name](https://github.com/your_username/repo_name)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

* [Choose an Open Source License](https://choosealicense.com)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Malven's Flexbox Cheatsheet](https://flexbox.malven.co/)
* [Malven's Grid Cheatsheet](https://grid.malven.co/)
* [Img Shields](https://shields.io)
* [GitHub Pages](https://pages.github.com)
* [Font Awesome](https://fontawesome.com)
* [React Icons](https://react-icons.github.io/react-icons/search)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
