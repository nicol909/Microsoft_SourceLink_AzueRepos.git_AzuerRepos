<Project Sdk="Microsoft.NET.Sdk">
 <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
 
    <!-- Optional: Publish the repository URL in the built .nupkg (in the NuSpec <Repository> element) -->
    <PublishRepositoryUrl>true</PublishRepositoryUrl>
 
    <!-- Optional: Embed source files that are not tracked by the source control manager in the PDB -->
    <EmbedUntrackedSources>true</EmbedUntrackedSources>
  
    <!-- Optional: Build symbol package (.snupkg) to distribute the PDB containing Source Link -->
    <IncludeSymbols>true</IncludeSymbols>
    <SymbolPackageFormat>snupkg</SymbolPackageFormat>
  </PropertyGroup>
  <ItemGroup>
    <!-- Add PackageReference specific for your source control provider (see below) --> 
  </ItemGroup>
</Project>
<ItemGroup>
   <PackageReference Include="Microsoft.SourceLink.GitHub" Version="1.0.0" PrivateAssets="All"/>
   <PackageReference Include="Microsoft.SourceLink.AzureRepos.Git" Version="1.0.0" PrivateAssets="All"/>
   <PackageReference Include="Microsoft.SourceLink.AzureDevOpsServer.Git" Version="1.0.0" PrivateAssets="All"/>
   <SourceLinkAzureDevOpsServerGitHost Include="server-name" VirtualDirectory="tfs"/> 
</ItemGroup>
<packages>
  <package id="Microsoft.Build.Tasks.Git" version="1.0.0" targetFramework="native" developmentDependency="true" />
  <package id="Microsoft.SourceLink.Common" version="1.0.0" targetFramework="native" developmentDependency="true" />
  <package id="Microsoft.SourceLink.GitHub" version="1.0.0" targetFramework="native" developmentDependency="true" />
</packages>
 <PropertyGroup>
    <AllowedOutputExtensionsInPackageBuildOutputFolder>$(AllowedOutputExtensionsInPackageBuildOutputFolder);.pdb</AllowedOutputExtensionsInPackageBuildOutputFolder>
  </PropertyGroup>  