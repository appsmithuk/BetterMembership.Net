﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("BetterMembershipProvider")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("BetterMembershipProvider")]
[assembly: ComVisible(false)]
[assembly: Guid("7367bbbb-7568-4e5b-996e-31fdd2405d70")]

#if SIGNED
[assembly: InternalsVisibleTo("BetterMembership.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f1061ea0d5d0eb099e3796f495bcfa7b50b9c48085233e18013cadfe86cb8a841547d0a26b0f1ddea1c5759d510032e031caf0925cac3346955127c2e52304bd825186bfb39b7048030549c006fa06070ca8b708c83a77d41a16cff0e43d7b72d2c61739766c048bec598f6ef7d9b0ad19aeaac8854133c0603a740a5f67e9b8")]
[assembly: InternalsVisibleTo("BetterMembership.IntegrationTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f1061ea0d5d0eb099e3796f495bcfa7b50b9c48085233e18013cadfe86cb8a841547d0a26b0f1ddea1c5759d510032e031caf0925cac3346955127c2e52304bd825186bfb39b7048030549c006fa06070ca8b708c83a77d41a16cff0e43d7b72d2c61739766c048bec598f6ef7d9b0ad19aeaac8854133c0603a740a5f67e9b8")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2,PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#else
[assembly: InternalsVisibleTo("BetterMembership.Tests")]
[assembly: InternalsVisibleTo("BetterMembership.IntegrationTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
